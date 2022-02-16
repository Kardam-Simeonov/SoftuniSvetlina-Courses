SELECT Weather.id FROM Weather
INNER JOIN Weather as Yesterday ON DateDiff(DAY, Yesterday.recordDate, Weather.recordDate) = 1
WHERE Weather.Temperature > Yesterday.Temperature;