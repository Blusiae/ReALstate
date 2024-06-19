using ReALstate.App.Data.Repositories.Interfaces;

namespace ReALstate.App.Data.Repositories
{
    internal class UnitOfWork(IAddressRepository addressRepository,
        IOfferRepository offerRepository,
        IApartmentRepository apartmentRepository,
        IHouseRepository houseRepository,
        ICustomerRepository customerRepository) : IUnitOfWork
    {
        public IAddressRepository AddressRepository { get; } = addressRepository;
        public IOfferRepository OfferRepository { get; } = offerRepository;
        public IApartmentRepository ApartmentRepository { get; } = apartmentRepository;
        public IHouseRepository HouseRepository { get; } = houseRepository;
        public ICustomerRepository CustomerRepository { get; } = customerRepository;

        public async Task InitAsync()
        {
            await AddressRepository.InitAsync();
            await OfferRepository.InitAsync();
            await ApartmentRepository.InitAsync();
            await HouseRepository.InitAsync();
            await CustomerRepository.InitAsync();
        }

    }

}
