﻿using MVCModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCClient.Builders.CommonTasks
{
    public interface ICommodityCategorySelectListBuilder
    {
        IEnumerable<SelectListItem> BuildSelectListItemsForCommodityCategories(IEnumerable<CommodityCategory> commodityCategories);
    }
}