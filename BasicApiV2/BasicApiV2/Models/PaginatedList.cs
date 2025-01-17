﻿namespace BasicApiV2.Models;

public class PaginatedList<T> where T : class
{
	public PaginatedList(List<T> items, int count, int pageIndex = 1, int pageSize = 10)
	{
		PageIndex  = pageIndex;
		PageSize   = pageSize;
		TotalPages = (int)Math.Ceiling(count / (double)pageSize);
		Items.AddRange(items);
	}

	public int PageIndex  { get; }
	public int PageSize   { get; }
	public int TotalPages { get; }

	public List<T> Items { get; } = new();

	public bool HasPreviousPage => PageIndex > 1;
	public bool HasNextPage     => PageIndex < TotalPages;
}