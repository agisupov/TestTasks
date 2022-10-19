WITH Query AS 
(
	SELECT s.IDSel, a.IDProd, (100.0 * sum(s.[Quantity])) / sum(sum(s.[Quantity])) over (partition by a.[IDProd]) AS  [Percent]
	FROM [Sales] AS s
	JOIN [Arrivals] AS a ON a.[IDProd] = s.[IDProd]
	WHERE s.[Date] between '01.10.2013' and '07.10.2013' and a.[Date] between '07.09.2013' and '07.10.2013'
	GROUP BY s.[IDSel], a.[IDProd]
)
SELECT (s.[Surname] + ' ' + s.[Name]) as [FullName], p.[Name] AS [ProductName], Query.[Percent]
FROM Query
RIGHT JOIN Sellers AS s ON s.[ID] = Query.[IDSel]
LEFT JOIN Products AS p ON p.[ID] = Query.[IDProd]
ORDER BY 1, 2;