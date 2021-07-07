-- Schema creation
CREATE SCHEMA tbfge;
USE tbfge;

-- Table creation
CREATE TABLE t_characters(
c_name VARCHAR(75) PRIMARY KEY,
c_vision VARCHAR(75),
c_rarity INTEGER,
c_weapon VARCHAR(75),
c_main INTEGER,
c_burst INTEGER,
c_support INTEGER,
c_heal BOOLEAN
);

-- Characters insertion
INSERT INTO t_characters VALUES
("Albedo", "Geo", 5, "Sword", 5, 4, 5, false),
("Amber", "Pyro", 4, "Bow", 2, 2, 3, false),
("Barbara", "Hydro", 4, "Catalyst", 2, 1, 4, true),
("Beidou", "Electro", 4, "Claymore", 3, 4, 4, false),
("Benett", "Pyro", 4, "Sword", 4, 3, 5, true),
("Chongyun", "Cryo", 4, "Claymore", 4, 4, 4, false),
("Diluc", "Pyro", 5, "Claymore", 5, 5, 2, false),
("Diona", "Cryo", 4, "Bow", 3, 2, 5, true),
("Fischl", "Electro", 4, "Bow", 4, 4, 5, false),
("Ganyu", "Cryo", 5, "Bow", 5, 5, 5, false),
("Hu Tao", "Pyro", 5, "Polearm", 5, 4, 4, false),
("Jean", "Anemo", 5, "Sword", 4, 5, 5, true),
("Kaeya", "Cryo", 4, "Sword", 1, 1, 2, false),
("Kazuha", "Anemo", 5, "Sword", 3, 4, 5, false),
("Keqing", "Electro", 5, "Sword", 5, 4, 1, false),
("Klee", "Pyro", 5, "Catalyst", 5, 5, 3, false),
("Lisa", "Electro", 4, "Catalyst", 1, 2, 2, false),
("Mona", "Hydro", 5, "Catalyst", 4, 4, 5, false),
("Ningguang", "Geo", 5, "Catalyst", 5, 4, 1, false),
("Noelle", "Geo", 4, "Claymore", 4, 4, 3, true),
("Qiqi", "Cryo", 5, "Sword", 3, 3, 5, true),
("Razor", "Electro", 4, "Claymore", 5, 4, 1, false),
("Rosalia", "Cryo", 4, "Polearm", 3, 3, 4, false),
("Sucrose", "Anemo", 4, "Catalyst", 4, 4, 4, false),
("Tartaglia", "Hydro", 5, "Bow", 5, 5, 3, false),
("Traveler anemo", "Anemo", 5, "Sword", 3, 4, 3, false),
("traveler geo", "Geo", 5, "Sword", 3, 4, 3, false),
("Venti", "Anemo", 5, "Bow", 4, 5, 5, false),
("Xiangling", "Pyro", 4, "Polearm", 3, 3, 4, false),
("Xiao", "Anemo", 5, "Polearm", 5, 5, 3, false),
("Xingqiu", "Hydro", 4, "Sword", 3, 3, 5, false),
("Xinyan", "Pyro", 4, "Claymore", 3, 4, 3, false),
("Zhongli", "Geo", 5, "Polearm", 4, 4, 5, false);
