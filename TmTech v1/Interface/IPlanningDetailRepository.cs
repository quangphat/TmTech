using System;
using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IPlanningDetailRepository
    {
        void Add(PlanningDetail entity);
        List<PlanningDetail> All();
        PlanningDetail Find(Guid id);
        void Remove(Guid id);
        void Remove(PlanningDetail entity);
        void Update(PlanningDetail entity);
        void RemovebyPlanning(Model.Planning planning);
    }
}
