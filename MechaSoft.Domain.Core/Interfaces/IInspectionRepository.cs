﻿using MechaSoft.Domain.Model;

namespace MechaSoft.Domain.Core.Interfaces;

public interface IInspectionRepository
{
    Task<Inspection> SaveAsync(Inspection inspection);
    Task<Inspection?> GetByIdAsync(Guid id);
    Task<IEnumerable<Inspection>> GetByVehicleIdAsync(Guid vehicleId);
    Task<IEnumerable<Inspection>> GetByServiceOrderIdAsync(Guid serviceOrderId);
    Task<IEnumerable<Inspection>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
    Task<IEnumerable<Inspection>> GetByResultAsync(InspectionResult result);
    Task<IEnumerable<Inspection>> GetPendingInspectionsAsync();
    Task<Inspection> UpdateAsync(Inspection inspection);
    Task DeleteAsync(Guid id);
}