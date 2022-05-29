﻿// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO DELIVER HUMANITARIAN AID, HOPE AND LOVE
// -------------------------------------------------------

using System;

namespace RefugeeLand.Core.Api.Models.MedicalConditions
{
    public class MedicalCondition
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AdditionalDetails { get; set; }
    }
}