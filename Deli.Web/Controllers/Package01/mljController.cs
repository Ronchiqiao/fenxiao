using System.Collections.Generic;
using Deli.Services.Interfaces.Package01;
using Deli.Entities.Package01;
using Deli.Web.Models.Package01;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using Deli.Web.Models;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Web.Controllers.Package01
{
	public class mljController:CommonController<mlj, ImljService, mljModel>
	{
		protected override string GetCurrentAreaPath()
		{
			 return "Package01_mlj";
		}


		protected override List<mlj> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<mlj> lists = this.Service.SelectBy(pagerSearchModel.Pager,new mlj { Name = pagerSearchModel.Name }, mlj => mlj.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
