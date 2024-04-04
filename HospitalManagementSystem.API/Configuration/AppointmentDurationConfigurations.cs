﻿using HospitalManagementSystem.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.API.Configuration
{
    public class AppointmentDurationConfigurations : IEntityTypeConfiguration<AppointmentDuration>
    {
        public void Configure(EntityTypeBuilder<AppointmentDuration> builder)
        {
            builder.Property(at => at.Name)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(at => at.Description)
                .HasMaxLength(255);
        }
    }
}
