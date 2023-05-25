using Microsoft.EntityFrameworkCore.Migrations;

namespace FranchiseePortal.Migrations
{
    public partial class Add_UpdateInsightSortOrder_StoredProc : Migration
    {
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			var createProcSql = @"
				IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'usp_UpdateInsightSortOrder')
					DROP PROCEDURE usp_UpdateInsightSortOrder
				GO

				CREATE PROCEDURE [dbo].[usp_UpdateInsightSortOrder](
					@Id int,
					@SortOrder int,
					@LastModifierUserId bigint,
					@LastModificationTime datetime
				)
				AS
				BEGIN
					--ensure @SortOrder is in the range for the existent Insights
					DECLARE @maxSortOrder int = (SELECT COUNT(Id) FROM Insights WHERE IsDeleted = 0);

					--find current row number of the Insights
					DECLARE @CurrentSortOrder int = (SELECT SortOrder
							FROM (
									SELECT Id, (ROW_NUMBER() over (order by SortOrder)) as SortOrder
									FROM Insights
									WHERE (IsDeleted IS NULL OR IsDeleted = 0)
								) as tSortOrder
							WHERE Id = @Id)

					IF(@SortOrder <= 0 )
						set @SortOrder = 1;
					if(@SortOrder > @maxSortOrder)
						set @SortOrder = @maxSortOrder;

					UPDATE Insights
					SET SortOrder = t.new_SortOrder,
					LastModifierUserId = @LastModifierUserId,
					LastModificationTime = @LastModificationTime
					FROM (
						SELECT
							(case 
								when (
								((ROW_NUMBER() over (order by SortOrder)) < @SortOrder and (ROW_NUMBER() over (order by SortOrder)) < @CurrentSortOrder)
									or
								((ROW_NUMBER() over (order by SortOrder)) > @SortOrder and (ROW_NUMBER() over (order by SortOrder)) > @CurrentSortOrder)
								)
								then (ROW_NUMBER() over (order by SortOrder)) --no change here
								when (
								((ROW_NUMBER() over (order by SortOrder)) <= @SortOrder and (ROW_NUMBER() over (order by SortOrder)) >= @CurrentSortOrder)
								)
								then (ROW_NUMBER() over (order by SortOrder)) - 1 --bump down 1 position
								when (
								((ROW_NUMBER() over (order by SortOrder)) >= @SortOrder and (ROW_NUMBER() over (order by SortOrder)) <= @CurrentSortOrder)
								)
								then (ROW_NUMBER() over (order by SortOrder)) + 1 --bump up 1 position
								else (ROW_NUMBER() over (order by SortOrder))
								end) as new_SortOrder, Id
							FROM Insights
							WHERE 
								(IsDeleted IS NULL OR IsDeleted = 0)
						) as t
						WHERE Insights.Id = t.Id

						update Insights
								SET SortOrder = @SortOrder,
								LastModifierUserId = @LastModifierUserId,
								LastModificationTime = @LastModificationTime
						WHERE Id = @Id
				END ";
			migrationBuilder.Sql(createProcSql);

		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("usp_UpdateInsightSortOrder");
		}
	}
}
