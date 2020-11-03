﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuuviCTRL.Core.Dto;
using RuuviCTRL.Core.Entities;
using RuuviCTRL.Core.Services.Interfaces;
using RuuviCTRL.SharedKernel.Interfaces;

namespace RuuviCTRL.Core.Services
{
    public class SLAService : ISLAService
    {
        private readonly IEFRepository _eFRepository;

        public SLAService(IEFRepository eFRepository)
        {
            _eFRepository = eFRepository;
        }

        public async Task<SLADto> GetSLADtoById(int id)
        {
            var slaEntitie = await _eFRepository.GetByIdAsync<SLAAgreement>(id);
            var slaDto = new SLADto
            {
                Id = slaEntitie.Id,
                HasTempratureBoundry = slaEntitie.HasTempratureBoundry,
                MaxTemprature = slaEntitie.MaxTemprature,
                MinTemprature = slaEntitie.MinTemprature,
                TempratureCount = slaEntitie.TempratureCount,
                TempratureTime = slaEntitie.TempratureTime,
                HasHumidityBoundry = slaEntitie.HasHumidityBoundry,
                MaxHumidity = slaEntitie.MaxHumidity,
                MinHumidity = slaEntitie.MinHumidity,
                HumidityCount = slaEntitie.HumidityCount,
                HumidityTime = slaEntitie.HumidityTime,
                HasPressureBoundry = slaEntitie.HasPressureBoundry,
                MaxPressure = slaEntitie.MaxPressure,
                MinPressure = slaEntitie.MinPressure,
                PressureCount = slaEntitie.PressureCount,
                PressureTime = slaEntitie.PressureTime,
                HasLocationBoundry = slaEntitie.HasLocationBoundry,
                LocationBoundary = slaEntitie.LocationBoundary,
                LocationCount = slaEntitie.LocationCount,
                LocationTime = slaEntitie.LocationTime,
                AssetId = slaEntitie.AssetId,
                CreatedAt = slaEntitie.CreatedAt
            };

            return slaDto;
        }

        public async Task<List<SLADto>> GetSLADtos()
        {
            var slaEntities = await _eFRepository.ListAsync<SLAAgreement>();
            var slaDtos = slaEntities.Select(s => new SLADto
            {
                Id = s.Id,
                HasTempratureBoundry = s.HasTempratureBoundry,
                MaxTemprature = s.MaxTemprature,
                MinTemprature = s.MinTemprature,
                TempratureCount = s.TempratureCount,
                TempratureTime = s.TempratureTime,
                HasHumidityBoundry = s.HasHumidityBoundry,
                MaxHumidity = s.MaxHumidity,
                MinHumidity = s.MinHumidity,
                HumidityCount = s.HumidityCount,
                HumidityTime = s.HumidityTime,
                HasPressureBoundry = s.HasPressureBoundry,
                MaxPressure = s.MaxPressure,
                MinPressure = s.MinPressure,
                PressureCount = s.PressureCount,
                PressureTime = s.PressureTime,
                HasLocationBoundry = s.HasLocationBoundry,
                LocationBoundary = s.LocationBoundary,
                LocationCount = s.LocationCount,
                LocationTime = s.LocationTime,
                AssetId = s.AssetId,
                CreatedAt = s.CreatedAt
            }).ToList();

            return slaDtos;
        }
    }
}