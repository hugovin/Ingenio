SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ExerciseB]
	@inCatlevel int
AS
BEGIN
	WITH CTE AS (
   -- Start from root categories
   SELECT CategoryId, ParentCategoryId, Name, Keywords, level = 1
   FROM Ingenio
   WHERE ParentCategoryId = -1

   UNION ALL

   -- Obtain next level category
   SELECT c1.CategoryId, c1.ParentCategoryId, 
          c1.Name, c1.Keywords, level = c2.level + 1
   FROM Ingenio AS c1
   INNER JOIN CTE AS c2 ON c1.ParentCategoryId   = c2.CategoryId
   WHERE c2.level < @inCatlevel -- terminate if specified level has been reached
)

SELECT CategoryId,ParentCategoryId,Name,Keywords
FROM CTE
WHERE level = @inCatlevel
ORDER  By CategoryId
END