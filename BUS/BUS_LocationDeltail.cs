using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TourDeltail : GenericRepository<TourDetail>
    {
        public BUS_TourDeltail()
        {

        }

        public void UpdateDetails(IList<TourDetail> tourDetails)
        {
            // remove range of tour detail by tour id
            _context.TourDetails.RemoveRange(this.GetAll().Where(x => x.TourId == tourDetails[0].TourId).ToList());
            foreach(var detail in tourDetails){
                var entity = new TourDetail{
                    TourId = detail.TourId,
                    LocationId = detail.LocationId,
                    Serial = detail.Serial
                };
                Insert(entity);
            }
        }

    }
}
