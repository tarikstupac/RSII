using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VGFeed.Model;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Database;
using VGFeed.WebAPI.Exceptions;

namespace VGFeed.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly _3123Context _context;
        private readonly IMapper _mapper;
        public KorisniciService(_3123Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public  List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }
            if (!string.IsNullOrWhiteSpace(request?.Username))
            {
                query = query.Where(x => x.Username.StartsWith(request.Username));
            }
            if (request.DrzavaId!=0)
            {
                query = query.Where(x => x.DrzavaId==request.DrzavaId);
            }
            if (request.UlogaId != 0)
            {
                query = query.Where(x => x.UlogaId == request.UlogaId);
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public  Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Korisnici>(request);
            var usercheck = _context.Korisnici.Where(x => x.Username == request.Username).ToList();
            if (usercheck.Count>0)
            {
                throw new UserException("Korisničko ime već postoji!");
            }
            if(request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Password se ne slaže!");
            }
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            entity.DatumKreiranja = DateTime.Now;
            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);  
        }

        public  Model.Korisnici Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Find(id);
            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);
            _mapper.Map(request, entity);
            if (!string.IsNullOrWhiteSpace(request.Password) && request.Password!="********")
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Password se ne slaže!");
                }
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity); 
        }

        public  Model.Korisnici Authenticiraj(string username, string password)
        {
            var user = _context.Korisnici.Include(x=>x.Uloga).FirstOrDefault(x => x.Username == username);
            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);

                if (newHash == user.PasswordHash && user.Aktivan)
                {
                    return _mapper.Map<Model.Korisnici>(user);
                }
            }
            return null;
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);
            return _mapper.Map<Model.Korisnici>(entity);
        }
    }
}
