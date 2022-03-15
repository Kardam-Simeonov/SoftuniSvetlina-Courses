SELECT PeakName FROM Peaks
ORDER BY PeakName ASC;

SELECT TOP(30) CountryName, Population
FROM Countries
INNER JOIN Continents ON Countries.ContinentCode = Continents.ContinentCode
WHERE ContinentName = 'Europe'
ORDER BY Population DESC,
CountryName ASC;

SELECT MountainsCountries.CountryCode, Mountains.MountainRange, Peaks.PeakName, Peaks.Elevation
FROM MountainsCountries
INNER JOIN Mountains ON MountainsCountries.MountainId = Mountains.Id
INNER JOIN Peaks ON Mountains.Id = Peaks.MountainId
WHERE MountainsCountries.CountryCode = 'BG' AND Peaks.Elevation > 2835
ORDER BY Peaks.Elevation DESC;