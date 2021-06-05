-- Schema creation
CREATE SCHEMA tbfge;
USE tbfge;


-- Table creation
CREATE TABLE t_characters(
c_name VARCHAR(75) PRIMARY KEY,
c_vision VARCHAR(75),
c_rarity INTEGER,
c_weapon VARCHAR(75)
);

-- Characters insertion
INSERT INTO t_characters VALUES
("Albedo", "Geo", 5, "Sword"),
("Amber", "Pyro", 4, "Bow"),
("Barbara", "Hydro", 4, "Catalyst"),
("Beidou", "Electro", 4, "Claymore"),
("Benett", "Pyro", 4, "Sword"),
("Chongyun", "Cryo", 4, "Claymore"),
("Diluc", "Pyro", 5, "Claymore"),
("Diona", "Cryo", 4, "Bow"),
("Fischl", "Electro", 4, "Bow"),
("Ganyu", "Cryo", 5, "Bow"),
("Hu Tao", "Pyro", 5, "Polearm"),
("Jean", "Anemo", 5, "Sword"),
("Kaeya", "Cryo", 4, "Sword"),
("Keqing", "Electro", 5, "Sword"),
("Klee", "Pyro", 5, "Catalyst"),
("Lisa", "Electro", 4, "Catalyst"),
("Mona", "Hydro", 5, "Catalyst"),
("Ningguang", "Geo", 5, "Catalyst"),
("Noelle", "Geo", 4, "Claymore"),
("Qiqi", "Cryo", 5, "Sword"),
("Razor", "Electro", 4, "Claymore"),
("Rosaria", "Cryo", 4, "Polearm"),
("Sucrose", "Anemo", 4, "Catalyst"),
("Tartaglia", "Hydro", 5, "Bow"),
("Traveler anemo", "Anemo", 5, "Sword"),
("traveler geo", "Geo", 5, "Sword"),
("Venti", "Anemo", 5, "Bow"),
("Xiangling", "Pyro", 4, "Polearm"),
("Xiao", "Anemo", 5, "Polearm"),
("Xingqiu", "Hydro", 4, "Sword"),
("Xinyan", "Pyro", 4, "Claymore"),
("Zhongli", "Geo", 5, "Polearm");
