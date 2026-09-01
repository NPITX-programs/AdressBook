ymd 20180115:
format: SELECT * FROM crime_scene_report
WHERE date = 20180115 AND city = 'SQL City' AND type = "murder"
	murder	Security footage shows that there were 2 witnesses. The first witness lives at the last house on "Northwestern Dr". The second witness, named Annabel, lives somewhere on "Franklin Ave".	SQL City
witnesses are:
___ name, lives on the last house on Northwestern Dr
Annabel, lives somewhere on "Franklin Ave"
first:
SELECT * FROM crime_scene_report
WHERE date = 20180115 AND city = 'SQL City' AND type = "murder"
SELECT * FROM person
WHERE name LIKE '%Annabel%' AND address_street_name = 'Franklin Ave'
