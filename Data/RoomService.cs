using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PokerWorld.Data
{
    public class RoomService
    {
        private Context _context;

        public RoomService(Context context)
        {
            _context = context;
        }

        public async Task<List<Room>> GetRoomsAsync()
        {
            return new List<Room>
            {

            };
        }

        public async Task<Room> GetByCode(string code)
        {
            var room = await _context.Rooms.SingleAsync(x => x.Code == code);

            return room;
        }

        public async Task<Room> Create()
        {
            return new Room();
        }
    }
}
