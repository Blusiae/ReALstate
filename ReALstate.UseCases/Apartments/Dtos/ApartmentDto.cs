﻿using ReALstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReALstate.UseCases.Apartments.Dtos
{
    public class ApartmentDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public double MetersSquared { get; set; }
        public double Value { get; set; }
        public State State { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Voivodeship { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string PostalCode { get; set; } = default!;
        public string Number { get; set; } = default!;
        public string ApartmentNumber { get; set; } = default!;
        public int OwnerId { get; set; }

        public DateTime? YearBuilt { get; set; }

        //Additional information
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public bool IsFurnushed { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasHeating { get; set; }
        public int Floor { get; set; }
        public bool IsElevatorAvailable { get; set; }
        public bool HasPrivateParkingSpace { get; set; }
    }
}