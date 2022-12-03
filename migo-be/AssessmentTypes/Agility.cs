﻿using System;
using System.ComponentModel.DataAnnotations;

namespace migo_be.AssessmentTypes
{
    public class Agility
    {
        [Key]
        public int Id { get; set; }
        
        public double CA_Q1 { get; set; }
        public double CA_Q2 { get; set; }
        public double CA_Q3 { get; set; }



    }
}

