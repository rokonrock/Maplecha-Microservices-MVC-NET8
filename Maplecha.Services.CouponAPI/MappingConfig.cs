﻿using AutoMapper;
using Maplecha.Services.CouponAPI.Models;
using Maplecha.Services.CouponAPI.Models.Dto;

namespace Maplecha.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
