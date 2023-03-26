﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Renting
{
    public class Rent
    {
        public int RentId { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string DescriptionRent { get; set; }

        public int DateDelayQuantity { get; set; }
        public string State { get; set; }
        public bool HoldingCCCD { get; set; }
        public int Deposit { get; set; }
        public int EstimatedCost { get; set; }
        public string CancellationReason { get; set; }

      
        public Rent(int rentId, int carId, int clientId, DateTime dateStart, DateTime dateEnd, int dateDelayQuantity, string state, bool holdingCCCD, int deposit, int estimatedCost, string cancellationReason)
        {
            RentId=rentId;
            CarId=carId;
            ClientId=clientId;
            DateStart=dateStart;
            DateEnd=dateEnd;
            DateDelayQuantity=dateDelayQuantity;
            State=state;
            HoldingCCCD=holdingCCCD;
            Deposit=deposit;
            EstimatedCost=estimatedCost;
            CancellationReason=cancellationReason;
        }

        public Rent() { }

        public Rent(int carId, DateTime dateStart, DateTime dateEnd, string descriptionRent)
        {
            CarId=carId;
            DateStart=dateStart;
            DateEnd=dateEnd;
            DescriptionRent=descriptionRent;
        }
    }
}
