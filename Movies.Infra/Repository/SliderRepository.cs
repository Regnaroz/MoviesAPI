using Dapper;
using Movies.Core.Common;
using Movies.Core.Data;
using Movies.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Movies.Infra.Repository
{
    public class SliderRepository: ISliderRepository
    {
        private readonly IDBContext DBContext;
        public SliderRepository(IDBContext DBContext)
        {
            this.DBContext = DBContext;
        }

        public bool DeleteSlider(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("DeleteSlider", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Slider> GetSlider()
        {
            IEnumerable<Slider> Result = DBContext.Connection.Query<Slider>("GetSlider", commandType: System.Data.CommandType.StoredProcedure);
            return Result.ToList();
        }

        public bool InsertSlider(Slider Slider)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Title", Slider.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Description", Slider.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Img", Slider.Img, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("InsertSlider", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateSlider(Slider Slider)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", Slider.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Title", Slider.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Description", Slider.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Img", Slider.Img, dbType: DbType.String, direction: ParameterDirection.Input);
            DBContext.Connection.ExecuteAsync("UpdateSlider", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
