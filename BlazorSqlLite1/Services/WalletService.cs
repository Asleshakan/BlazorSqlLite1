// Services/WalletService.cs
using BlazorSqlLite1.Data;
using BlazorSqlLite1.dbcontext;
using BlazorSqlLite1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSqlLite1.Services
{
    public class WalletService
    {
        private readonly AppDbContext _context;

        public WalletService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Wallet>> GetWalletsAsync()
        {
            return await _context.wallets.ToListAsync();
        }

        public async Task<Wallet> GetWalletByIdAsync(int id)
        {
            return await _context.wallets.FindAsync(id);
        }

        public async Task AddWalletAsync(Wallet wallet)
        {
            _context.wallets.Add(wallet);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteWalletAsync(int id)
        {
            var wallet = await GetWalletByIdAsync(id);
            if (wallet != null)
            {
                _context.wallets.Remove(wallet);
                await _context.SaveChangesAsync();
            }
        }
    }
}
