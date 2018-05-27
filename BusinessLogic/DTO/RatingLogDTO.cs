﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Domain;

namespace BusinessLogic.DTO
{
    public class RatingLogDTO
    {
        public int RatingLogId { get; set; }
        [Range(0, 10)]
        public int Rating { get; set; }
        [MaxLength(2000)]
        public string Comment { get; set; }

        public static RatingLogDTO CreateFromDomain(RatingLog ratingLog)
        {
            if (ratingLog == null) { return null; }
            return new RatingLogDTO()
            {
                RatingLogId = ratingLog.RatingLogId,
                Rating = ratingLog.Rating,
                Comment = ratingLog.Comment
            };
        }
    }

    public class RatingLogForEntityDTO
    {
        [Range(0, 10)]
        public int Rating { get; set; }
        [MaxLength(2000)]
        public string Comment { get; set; }
        //foreign keys
        public int? RestaurantId { get; set; }
        public int? DishId { get; set; }
        [Required]
        public string UserId { get; set; }

        public static RatingLogForEntityDTO CreateFromDomain(RatingLog ratingLog)
        {
            if (ratingLog == null) { return null; }
            return new RatingLogForEntityDTO()
            {
                Rating = ratingLog.Rating,
                Comment = ratingLog.Comment,
                RestaurantId = ratingLog.RestaurantId,
                DishId = ratingLog.DishId,
                UserId = ratingLog.UserId
            };
        }
    }

}
