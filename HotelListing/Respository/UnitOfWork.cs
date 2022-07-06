using HotelListing.Data;
using HotelListing.IRespository;
using System;
using System.Threading.Tasks;

namespace HotelListing.Respository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _context;
        private IGenerticRespository<Country> _coutries;
        private IGenerticRespository<Hotel> _hotels;
        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
            
        }
        public IGenerticRespository<Country> Countries => _coutries ??= new GenericRespository<Country>(_context);

        public IGenerticRespository<Hotel> Hotels => _hotels ??= new GenericRespository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
