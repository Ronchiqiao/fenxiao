using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Deli.Entities.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Web.Models.Package01
{
	public class mljModel: CommonModel<mlj>
	{
		public string mkl {get; set;}

		public override void PopulateFrom(mlj entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.mkl = entity.mkl;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(mlj entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.mkl = this.mkl;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
