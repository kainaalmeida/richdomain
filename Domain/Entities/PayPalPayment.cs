﻿using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment
            (
            string transcationCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Address address,
            Email email) :
            base
            (
             paidDate,
             expireDate,
             total,
             totalPaid,
             payer,
             document,
             address,
             email)
        {
            TranscationCode = transcationCode;
        }

        public string TranscationCode { get; private set; }
    }
}
