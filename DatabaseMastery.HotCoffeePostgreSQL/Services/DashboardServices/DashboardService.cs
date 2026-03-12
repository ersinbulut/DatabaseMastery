using AutoMapper;
using DatabaseMastery.HotCoffeePostgreSQL.Context;
using DatabaseMastery.HotCoffeePostgreSQL.Dtos.ReservationDtos;
using Microsoft.EntityFrameworkCore;

namespace DatabaseMastery.HotCoffeePostgreSQL.Services.DashboardServices
{
    public class DashboardService : IDashboardService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public DashboardService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> GetApprovedReservationCountAsync()
        {
            return await _context.Reservations.CountAsync(x => x.Status == "Onaylandı");
        }

        public async Task<int> GetCancelledReservationCountAsync()
        {
            return await _context.Reservations.CountAsync(x => x.Status == "İptal Edildi");
        }

        public async Task<int> GetPendingReservationCountAsync()
        {
            return await _context.Reservations.CountAsync(x => x.Status == "Beklemede");
        }

        public async Task<int> GetTodayOrderCountAsync()
        {
            // Eğer Orders tablon varsa burada kullanılır
            return 0;
        }

        public async Task<int> GetTodayReservationCountAsync()
        {
            var today = DateTime.UtcNow.Date;
            var tomorrow = today.AddDays(1);

            return await _context.Reservations
                .CountAsync(x => x.ReservationDate >= today && x.ReservationDate < tomorrow);
        }

        public async Task<List<ResultReservationDto>> GetTodayReservationListAsync()
        {
            var today = DateTime.UtcNow.Date;
            var tomorrow = today.AddDays(1);

            var values = await _context.Reservations
                .Where(r => r.ReservationDate >= today && r.ReservationDate < tomorrow)
                .OrderBy(r => r.ReservationTime)
                .ToListAsync();

            return _mapper.Map<List<ResultReservationDto>>(values);
        }

        public async Task<int> GetTotalCustomerCountAsync()
        {
            return await _context.Reservations.SumAsync(x => x.GuestCount);
        }

        public async Task<int> GetTotalMenuProductCountAsync()
        {
            return await _context.Products.CountAsync();
        }

        public async Task<int> GetTotalReservationCountAsync()
        {
            return await _context.Reservations.CountAsync();
        }
    }
}