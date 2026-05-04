using System;
using System.Collections.Generic;

namespace Session3_Desktop.models;

public partial class CustomOrder
{
    public int CustomOrderId { get; set; }

    public int ProductId { get; set; }

    public string CustomizationType { get; set; } = null!;

    public string CustomizationOption { get; set; } = null!;

    public decimal AdditionalCost { get; set; }

    public string? PrerequisiteOption { get; set; }

    public int? MaxQuantity { get; set; }

    public string ApplicableCategories { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
