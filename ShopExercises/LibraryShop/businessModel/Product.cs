﻿namespace LibraryShop.businessModel;

public class Product
{
    public Guid Id { get; } = Guid.NewGuid();
    public Dictionary<TimeRange, ProductState> MapProductState { get; set; } = new Dictionary<TimeRange, ProductState>();

}
