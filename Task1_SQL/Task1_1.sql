SELECT ([Surname] + ' ' + [Name]) as [FullName], Sum(Quantity) AS [SumQuantity]
FROM [Sales] AS s
JOIN [Sellers] ON s.[IDSel]=[Sellers].[ID]
WHERE s.[Date] BETWEEN '01.10.2013' AND '07.10.2013'
GROUP BY ([Surname] + ' ' + [Name])
ORDER BY 1;