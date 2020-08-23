using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGFeed.Model;
using VGFeed.Model.Requests;
using VGFeed.WebAPI.Database;
using Stripe;

namespace VGFeed.WebAPI.Services
{
    public class PaymentService : IPaymentService
    {
        protected readonly _3123Context _context;
        protected readonly IMapper _mapper;

        public PaymentService(_3123Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Donacije Insert(DonacijeInsertRequest request)
        {
            var options = new ChargeCreateOptions
            {
                Amount = Convert.ToInt32(request.Kolicina * 100), 
                Currency = "usd", 
                Description = "Donacija za VGFeed app",
                Source = request.Token
            };

            var service = new ChargeService();

            try
            {
                Charge charge = service.Create(options);
            }
            catch (StripeException ex)
            {
                StripeError stripeError = ex.StripeError;

                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw (ex);
            }

            var entity = _mapper.Map<Database.Donacije>(request);

            _context.Set<Database.Donacije>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Donacije>(entity);
        }
    }
}
