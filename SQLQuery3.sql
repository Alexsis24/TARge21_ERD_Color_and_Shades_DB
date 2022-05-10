SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
join  Shades on Shades.PrimaryColorId = PrimaryColors.Id

SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
inner join  Shades on Shades.PrimaryColorId = PrimaryColors.Id
where PrimaryColors.PrimaryColorName like 'Red'

SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
inner join  Shades on Shades.PrimaryColorId = PrimaryColors.Id
where PrimaryColors.PrimaryColorName like 'Blue'

SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
inner join  Shades on Shades.PrimaryColorId = PrimaryColors.Id
where PrimaryColors.PrimaryColorName like 'Yellow'

SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
inner join  Shades on Shades.PrimaryColorId = PrimaryColors.Id
where PrimaryColors.PrimaryColorName like 'Green'
