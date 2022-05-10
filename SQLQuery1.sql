SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
join  Shades on Shades.PrimaryColorId = PrimaryColors.Id

SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
inner join  Shades on Shades.PrimaryColorId = PrimaryColors.Id
where PrimaryColor.PrimaryColorName like 'Red'

SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
inner join  Shades on Shades.PrimaryColorId = PrimaryColors.Id
where PrimaryColor.PrimaryColorName like 'Blue'

SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
inner join  Shades on Shades.PrimaryColorId = PrimaryColors.Id
where PrimaryColor.PrimaryColorName like 'Yellow'

SELECT Shades.ColorName, PrimaryColors.PrimaryColorName from PrimaryColors
inner join  Shades on Shades.PrimaryColorId = PrimaryColors.Id
where PrimaryColor.PrimaryColorName like 'Green'
