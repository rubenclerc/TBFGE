-- Schema creation
CREATE SCHEMA tbfge;
USE tbfge;

-- Tables creation
CREATE TABLE t_characters(
c_name VARCHAR(75) PRIMARY KEY,
c_vision VARCHAR(75),
c_weapon VARCHAR(75),
c_main INTEGER,
c_burst INTEGER,
c_support INTEGER,
c_heal BOOLEAN
);

CREATE TABLE t_team(
c_name VARCHAR(75) PRIMARY KEY,
c_vision VARCHAR(75),
c_weapon VARCHAR(75),
c_main INTEGER,
c_burst INTEGER,
c_support INTEGER,
c_heal BOOLEAN
);


-- Characters insertion
INSERT INTO t_characters VALUES
("Albedo", "Geo", "Sword", 5, 4, 5, false),
("Amber", "Pyro", "Bow", 2, 2, 3, false),
("Barbara", "Hydro", "Catalyst", 2, 1, 4, true),
("Beidou", "Electro", "Claymore", 3, 4, 4, false),
("Benett", "Pyro", "Sword", 4, 3, 5, true),
("Chongyun", "Cryo", "Claymore", 4, 4, 4, false),
("Diluc", "Pyro", "Claymore", 5, 5, 2, false),
("Diona", "Cryo", "Bow", 3, 2, 5, true),
("Fischl", "Electro", "Bow", 4, 4, 5, false),
("Ganyu", "Cryo", "Bow", 5, 5, 5, false),
("Hu Tao", "Pyro", "Polearm", 5, 4, 4, false),
("Jean", "Anemo", "Sword", 4, 5, 5, true),
("Kaeya", "Cryo", "Sword", 1, 1, 2, false),
("Kazuha", "Anemo", "Sword", 3, 4, 5, false),
("Keqing", "Electro", "Sword", 5, 4, 1, false),
("Klee", "Pyro", "Catalyst", 5, 5, 3, false),
("Lisa", "Electro", "Catalyst", 1, 2, 2, false),
("Mona", "Hydro", "Catalyst", 4, 4, 5, false),
("Ningguang", "Geo", "Catalyst", 5, 4, 1, false),
("Noelle", "Geo", "Claymore", 4, 4, 3, true),
("Qiqi", "Cryo", "Sword", 3, 3, 5, true),
("Razor", "Electro", "Claymore", 5, 4, 1, false),
("Rosalia", "Cryo", "Polearm", 3, 3, 4, false),
("Sucrose", "Anemo", "Catalyst", 4, 4, 4, false),
("Tartaglia", "Hydro", "Bow", 5, 5, 3, false),
("Traveler anemo", "Anemo", "Sword", 3, 4, 3, false),
("traveler geo", "Geo", "Sword", 3, 4, 3, false),
("Venti", "Anemo", "Bow", 4, 5, 5, false),
("Xiangling", "Pyro", "Polearm", 3, 3, 4, false),
("Xiao", "Anemo", "Polearm", 5, 5, 3, false),
("Xingqiu", "Hydro", "Sword", 3, 3, 5, false),
("Xinyan", "Pyro", "Claymore", 3, 4, 3, false),
("Zhongli", "Geo", "Polearm", 4, 4, 5, false);
