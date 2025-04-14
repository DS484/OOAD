using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReservationDTO
    {
        private int reservationId;
        private DateTime createdAt;
        private int roomId;
        private string customerName;

        public ReservationDTO(int reservationId, DateTime createdAt, int roomId, string customerName)
        {
            this.reservationId = reservationId;
            this.createdAt = createdAt;
            this.roomId = roomId;
            this.customerName = customerName;
        }
    }
}
