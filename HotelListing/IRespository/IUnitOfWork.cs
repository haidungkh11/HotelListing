using HotelListing.Data;
using System;
using System.Threading.Tasks;

namespace HotelListing.IRespository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenerticRespository<Country> Countries { get; }
        IGenerticRespository<Hotel> Hotels { get; }
        Task Save();
    }
}
