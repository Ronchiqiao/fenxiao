using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Deli.Entities.Package01;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Deli.Web.Models.Package01
{
	public class lpoiModel: CommonModel<lpoi>
	{
		public string klj {get; set;}

		public override void PopulateFrom(lpoi entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.klj = entity.klj;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(lpoi entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.klj = this.klj;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
