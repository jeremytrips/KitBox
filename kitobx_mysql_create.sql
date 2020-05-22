/*
ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 ;
*/

DROP SCHEMA IF EXISTS `kitbox` ;
CREATE DATABASE kitbox;
use kitbox ;

DROP TABLE IF EXISTS `client_order`;
CREATE TABLE `client_order` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`id_order` INT NOT NULL,
	`date` DATE NOT NULL,
	`price` FLOAT NOT NULL,
	`already_paid` FLOAT NOT NULL,
	`order_name` varchar(25) NOT NULL UNIQUE,
	PRIMARY KEY (`id`)
);

DROP TABLE IF EXISTS `client_order_component`;
CREATE TABLE `client_order_component` (
	`id` INT NOT NULL AUTO_INCREMENT,
	`id_order` INT NOT NULL,
	`code` varchar(15) NOT NULL,
	`quantity` INT NOT NULL,
	PRIMARY KEY (`id`)
);

DROP TABLE IF EXISTS `component`;
CREATE TABLE `component` (
	`code` varchar(15) NOT NULL,
	`height` INT NOT NULL,
	`width` INT NOT NULL,
	`depth` INT NOT NULL,
	`reference` varchar(25) NOT NULL,
	`color` varchar(15),
	`stock` INT NOT NULL,
	`stock_min_required` INT NOT NULL,
	`price` FLOAT NOT NULL,
	`number_by_box` INT NOT NULL,
	`order_quantity` INT NOT NULL,
	`to_order` BOOLEAN NOT NULL,
	PRIMARY KEY (`code`)
);

DROP TABLE IF EXISTS `supplier`;
CREATE TABLE `supplier` (
	`id_supplier` INT NOT NULL AUTO_INCREMENT,
	`name` varchar(25) NOT NULL,
	`address` varchar(255) NOT NULL,
	PRIMARY KEY (`id_supplier`)
);

DROP TABLE IF EXISTS `supplier_order_component`;
CREATE TABLE `supplier_order_component` (
	`id_order` INT NOT NULL,
	`component_code` varchar(15) NOT NULL,
	`quantity` INT(15) NOT NULL
);

DROP TABLE IF EXISTS `supplier_order`;
CREATE TABLE `supplier_order` (
	`id_order` INT NOT NULL AUTO_INCREMENT,
	`id_supplier` INT NOT NULL,
	PRIMARY KEY (`id_order`)
);

DROP TABLE IF EXISTS `price`;
CREATE TABLE `price` (
	`id_supplier` INT NOT NULL,
	`component_code` varchar(15) NOT NULL,
	`delivery_delay` INT NOT NULL,
	`price` FLOAT NOT NULL
);

insert into kitbox.supplier(id_supplier, name, address) values
(1, "TRABELBO SA ", "Les Artisans du Bois Parc industriel 9 6124 MARBEHAN"),
(2, "TraitBois SPRL", "Ebenistes reunis Chemin des 2 Maisons, 140 5150 : Floriffoux");


INSERT INTO kitbox.component(code, height, width, depth, reference, color, stock, stock_min_required, price, number_by_box, order_quantity, to_order) VALUES
("COR46BL",46,0,0,"Cornieres","Blanc",82,32,0.45,4,32,0),
("﻿COR36BL",36,0,0,"Cornieres","Blanc",84,32,0.35,4,32,0),
("COR56BL",56,0,0,"Cornieres","Blanc",89,32,0.55,4,32,0),
("COR72BL",72,0,0,"Cornieres","Blanc",82,32,0.66,4,32,0),
("COR92BL",92,0,0,"Cornieres","Blanc",85,32,0.86,4,32,0),
("COR108BL",108,0,0,"Cornieres","Blanc",84,32,0.97,4,32,0),
("COR112BL",112,0,0,"Cornieres","Blanc",82,32,1.06,4,32,0),
("COR138BL",138,0,0,"Cornieres","Blanc",83,32,1.27,4,32,0),
("COR144BL",144,0,0,"Cornieres","Blanc",86,32,1.28,4,32,0),
("COR168BL",168,0,0,"Cornieres","Blanc",89,32,1.57,4,32,0),
("COR180BL",180,0,0,"Cornieres","Blanc",89,32,1.59,4,32,0),
("COR184BL",184,0,0,"Cornieres","Blanc",89,32,1.68,4,32,0),
("COR216BL",216,0,0,"Cornieres","Blanc",84,32,1.9,4,32,0),
("COR224BL",224,0,0,"Cornieres","Blanc",84,32,2.08,4,32,0),
("COR230BL",230,0,0,"Cornieres","Blanc",83,32,2.09,4,32,0),
("COR252BL",252,0,0,"Cornieres","Blanc",80,32,2.21,4,32,0),
("COR276BL",276,0,0,"Cornieres","Blanc",86,32,2.5,4,32,0),
("COR280BL",280,0,0,"Cornieres","Blanc",84,32,2.59,4,32,0),
("COR36BR",36,0,0,"Cornieres","Brun",82,32,0.28,4,32,0),
("COR46BR",46,0,0,"Cornieres","Brun",87,32,0.36,4,32,0),
("COR56BR",56,0,0,"Cornieres","Brun",86,32,0.44,4,32,0),
("COR72BR",72,0,0,"Cornieres","Brun",85,32,0.528,4,32,0),
("COR92BR",92,0,0,"Cornieres","Brun",83,32,0.688,4,32,0),
("COR108BR",108,0,0,"Cornieres","Brun",87,32,0.776,4,32,0),
("COR112BR",112,0,0,"Cornieres","Brun",82,32,0.848,4,32,0),
("COR138BR",138,0,0,"Cornieres","Brun",87,32,1.016,4,32,0),
("COR144BR",144,0,0,"Cornieres","Brun",87,32,1.024,4,32,0),
("COR168BR",168,0,0,"Cornieres","Brun",83,32,1.256,4,32,0),
("COR180BR",180,0,0,"Cornieres","Brun",89,32,1.272,4,32,0),
("COR184BR",184,0,0,"Cornieres","Brun",84,32,1.344,4,32,0),
("COR216BR",216,0,0,"Cornieres","Brun",81,32,1.52,4,32,0),
("COR224BR",224,0,0,"Cornieres","Brun",83,32,1.664,4,32,0),
("COR230BR",230,0,0,"Cornieres","Brun",80,32,1.672,4,32,0),
("COR252BR",252,0,0,"Cornieres","Brun",89,32,1.768,4,32,0),
("COR276BR",276,0,0,"Cornieres","Brun",90,32,2,4,32,0),
("COR280BR",280,0,0,"Cornieres","Brun",86,32,2.072,4,32,0),
("COR36GL",36,0,0,"Cornieres","Galvanise",81,32,0.35,4,32,0),
("COR46GL",46,0,0,"Cornieres","Galvanise",82,32,0.45,4,32,0),
("COR56GL",56,0,0,"Cornieres","Galvanise",82,32,0.55,4,32,0),
("COR72GL",72,0,0,"Cornieres","Galvanise",83,32,0.66,4,32,0),
("COR92GL",92,0,0,"Cornieres","Galvanise",82,32,0.86,4,32,0),
("COR108GL",108,0,0,"Cornieres","Galvanise",87,32,0.97,4,32,0),
("COR112GL",112,0,0,"Cornieres","Galvanise",88,32,1.06,4,32,0),
("COR138GL",138,0,0,"Cornieres","Galvanise",89,32,1.27,4,32,0),
("COR144GL",144,0,0,"Cornieres","Galvanise",84,32,1.28,4,32,0),
("COR168GL",168,0,0,"Cornieres","Galvanise",88,32,1.57,4,32,0),
("COR180GL",180,0,0,"Cornieres","Galvanise",84,32,1.59,4,32,0),
("COR184GL",184,0,0,"Cornieres","Galvanise",86,32,1.68,4,32,0),
("COR216GL",216,0,0,"Cornieres","Galvanise",88,32,1.9,4,32,0),
("COR224GL",224,0,0,"Cornieres","Galvanise",87,32,2.08,4,32,0),
("COR230GL",230,0,0,"Cornieres","Galvanise",88,32,2.09,4,32,0),
("COR252GL",252,0,0,"Cornieres","Galvanise",89,32,2.21,4,32,0),
("COR276GL",276,0,0,"Cornieres","Galvanise",81,32,2.5,4,32,0),
("COR280GL",280,0,0,"Cornieres","Galvanise",86,32,2.59,4,32,0),
("COR36NR",36,0,0,"Cornieres","Noir",84,32,0.245,4,32,0),
("COR46NR",46,0,0,"Cornieres","Noir",90,32,0.315,4,32,0),
("COR56NR",56,0,0,"Cornieres","Noir",89,32,0.385,4,32,0),
("COR72NR",72,0,0,"Cornieres","Noir",81,32,0.462,4,32,0),
("COR92NR",92,0,0,"Cornieres","Noir",87,32,0.602,4,32,0),
("COR108NR",108,0,0,"Cornieres","Noir",86,32,0.679,4,32,0),
("COR112NR",112,0,0,"Cornieres","Noir",89,32,0.742,4,32,0),
("COR138NR",138,0,0,"Cornieres","Noir",83,32,0.889,4,32,0),
("COR144NR",144,0,0,"Cornieres","Noir",88,32,0.896,4,32,0),
("COR168NR",168,0,0,"Cornieres","Noir",80,32,1.099,4,32,0),
("COR180NR",180,0,0,"Cornieres","Noir",83,32,1.113,4,32,0),
("COR184NR",184,0,0,"Cornieres","Noir",88,32,1.176,4,32,0),
("COR216NR",216,0,0,"Cornieres","Noir",80,32,1.33,4,32,0),
("COR224NR",224,0,0,"Cornieres","Noir",84,32,1.456,4,32,0),
("COR230NR",230,0,0,"Cornieres","Noir",83,32,1.463,4,32,0),
("COR252NR",252,0,0,"Cornieres","Noir",80,32,1.547,4,32,0),
("COR276NR",276,0,0,"Cornieres","Noir",83,32,1.75,4,32,0),
("COR280NR",280,0,0,"Cornieres","Noir",86,32,1.813,4,32,0),
("COUPEL",0,0,0,"Coupelles",NULL,42,16,0.005,2,16,0),
("COR50BLDEC",50,0,0,"Cornieres","Blanc",84,32,1.1,4,32,0),
("COR50BRDEC",50,0,0,"Cornieres","Brun",86,32,0.88,4,32,0),
("COR50GLDEC",50,0,0,"Cornieres","Galvanise",82,32,1.1,4,32,0),
("COR50NRDEC",50,0,0,"Cornieres","Noir",82,32,0.77,4,32,0),
("COR75BLDEC",75,0,0,"Cornieres","Blanc",89,32,1.32,4,32,0),
("COR75BRDEC",75,0,0,"Cornieres","Brun",83,32,1.06,4,32,0),
("COR75GLDEC",75,0,0,"Cornieres","Galvanise",84,32,1.32,4,32,0),
("COR75NRDEC",75,0,0,"Cornieres","Noir",81,32,0.92,4,32,0),
("COR100BLDEC",100,0,0,"Cornieres","Blanc",85,32,1.72,4,32,0),
("COR100BRDEC",100,0,0,"Cornieres","Brun",84,32,1.38,4,32,0),
("COR100GLDEC",100,0,0,"Cornieres","Galvanise",84,32,1.72,4,32,0),
("COR100NRDEC",100,0,0,"Cornieres","Noir",87,32,1.2,4,32,0),
("COR125BLDEC",125,0,0,"Cornieres","Blanc",83,32,1.94,4,32,0),
("COR125BRDEC",125,0,0,"Cornieres","Brun",84,32,1.55,4,32,0),
("COR125GLDEC",125,0,0,"Cornieres","Galvanise",83,32,1.94,4,32,0),
("COR125NRDEC",125,0,0,"Cornieres","Noir",86,32,1.36,4,32,0),
("COR150BLDEC",150,0,0,"Cornieres","Blanc",89,32,2.54,4,32,0),
("COR150BRDEC",150,0,0,"Cornieres","Brun",87,32,2.03,4,32,0),
("COR150GLDEC",150,0,0,"Cornieres","Galvanise",87,32,2.54,4,32,0),
("COR150NRDEC",150,0,0,"Cornieres","Noir",87,32,1.78,4,32,0),
("COR175BLDEC",175,0,0,"Cornieres","Blanc",81,32,3.14,4,32,0),
("COR175BRDEC",175,0,0,"Cornieres","Brun",83,32,2.51,4,32,0),
("COR175GLDEC",175,0,0,"Cornieres","Galvanise",86,32,3.14,4,32,0),
("COR175NRDEC",175,0,0,"Cornieres","Noir",85,32,2.2,4,32,0),
("COR200BLDEC",200,0,0,"Cornieres","Blanc",85,32,3.36,4,32,0),
("COR200BRDEC",200,0,0,"Cornieres","Brun",86,32,2.69,4,32,0),
("COR200GLDEC",200,0,0,"Cornieres","Galvanise",84,32,3.36,4,32,0),
("COR200NRDEC",200,0,0,"Cornieres","Noir",90,32,2.35,4,32,0),
("COR225BLDEC",225,0,0,"Cornieres","Blanc",88,32,3.8,4,32,0),
("COR225BRDEC",225,0,0,"Cornieres","Brun",86,32,3.04,4,32,0),
("COR225GLDEC",225,0,0,"Cornieres","Galvanise",86,32,3.8,4,32,0),
("COR225NRDEC",225,0,0,"Cornieres","Noir",88,32,2.66,4,32,0),
("COR250BLDEC",250,0,0,"Cornieres","Blanc",87,32,4.42,4,32,0),
("COR250BRDEC",250,0,0,"Cornieres","Brun",81,32,3.54,4,32,0),
("COR250GLDEC",250,0,0,"Cornieres","Galvanise",82,32,4.42,4,32,0),
("COR250NRDEC",250,0,0,"Cornieres","Noir",86,32,3.09,4,32,0),
("COR275BLDEC",275,0,0,"Cornieres","Blanc",82,32,5,4,32,0),
("COR275BRDEC",275,0,0,"Cornieres","Brun",82,32,4,4,32,0),
("COR275GLDEC",275,0,0,"Cornieres","Galvanise",87,32,5,4,32,0),
("COR275NRDEC",275,0,0,"Cornieres","Noir",81,32,3.5,4,32,0),
("COR300BLDEC",300,0,0,"Cornieres","Blanc",90,32,5.18,4,32,0),
("COR300BRDEC",300,0,0,"Cornieres","Brun",88,32,4.14,4,32,0),
("COR300GLDEC",300,0,0,"Cornieres","Galvanise",83,32,5.18,4,32,0),
("COR300NRDEC",300,0,0,"Cornieres","Noir",84,32,3.63,4,32,0),
("COR325BLDEC",325,0,0,"Cornieres","Blanc",86,32,5.18,4,32,0),
("COR325BRDEC",325,0,0,"Cornieres","Brun",88,32,4.14,4,32,0),
("COR325GLDEC",325,0,0,"Cornieres","Galvanise",90,32,5.18,4,32,0),
("COR325NRDEC",325,0,0,"Cornieres","Noir",87,32,3.63,4,32,0),
("COR350BLDEC",350,0,0,"Cornieres","Blanc",84,32,5.18,4,32,0),
("COR350BRDEC",350,0,0,"Cornieres","Brun",84,32,4.14,4,32,0),
("COR350GLDEC",350,0,0,"Cornieres","Galvanise",83,32,5.18,4,32,0),
("COR350NRDEC",350,0,0,"Cornieres","Noir",85,32,3.63,4,32,0),
("COR375BLDEC",375,0,0,"Cornieres","Blanc",82,32,5.18,4,32,0),
("COR375BRDEC",375,0,0,"Cornieres","Brun",81,32,4.14,4,32,0),
("COR375GLDEC",375,0,0,"Cornieres","Galvanise",86,32,5.18,4,32,0),
("COR375NRDEC",375,0,0,"Cornieres","Noir",89,32,3.63,4,32,0),
("PAR32100BL",32,100,0,"Panneau Ar","Blanc",21,8,16,1,8,0),
("PAR32120BL",32,120,0,"Panneau Ar","Blanc",30,8,19.2,1,8,0),
("PAR3232BL",32,32,0,"Panneau Ar","Blanc",23,8,5.12,1,8,0),
("PAR3242BL",32,42,0,"Panneau Ar","Blanc",29,8,6.72,1,8,0),
("PAR3252BL",32,52,0,"Panneau Ar","Blanc",21,8,8.32,1,8,0),
("PAR3262BL",32,62,0,"Panneau Ar","Blanc",26,8,9.92,1,8,0),
("PAR3280BL",32,80,0,"Panneau Ar","Blanc",25,8,12.8,1,8,0),
("PAR42100BL",42,100,0,"Panneau Ar","Blanc",27,8,26,1,8,0),
("PAR42120BL",42,120,0,"Panneau Ar","Blanc",30,8,31.2,1,8,0),
("PAR4232BL",42,32,0,"Panneau Ar","Blanc",23,8,8.32,1,8,0),
("PAR4242BL",42,42,0,"Panneau Ar","Blanc",29,8,10.92,1,8,0),
("PAR4252BL",42,52,0,"Panneau Ar","Blanc",24,8,13.52,1,8,0),
("PAR4262BL",42,62,0,"Panneau Ar","Blanc",30,8,16.12,1,8,0),
("PAR4280BL",42,80,0,"Panneau Ar","Blanc",24,8,20.8,1,8,0),
("PAR52100BL",52,100,0,"Panneau Ar","Blanc",27,8,26,1,8,0),
("PAR52120BL",52,120,0,"Panneau Ar","Blanc",30,8,31.2,1,8,0),
("PAR5232BL",52,32,0,"Panneau Ar","Blanc",28,8,8.32,1,8,0),
("PAR5242BL",52,42,0,"Panneau Ar","Blanc",20,8,10.92,1,8,0),
("PAR5252BL",52,52,0,"Panneau Ar","Blanc",22,8,13.52,1,8,0),
("PAR5262BL",52,62,0,"Panneau Ar","Blanc",28,8,16.12,1,8,0),
("PAR5280BL",52,80,0,"Panneau Ar","Blanc",28,8,20.8,1,8,0),
("PAR32100BR",32,100,0,"Panneau Ar","Brun",23,8,12.8,1,8,0),
("PAR32120BR",32,120,0,"Panneau Ar","Brun",29,8,15.36,1,8,0),
("PAR3232BR",32,32,0,"Panneau Ar","Brun",26,8,4.096,1,8,0),
("PAR3242BR",32,42,0,"Panneau Ar","Brun",21,8,5.376,1,8,0),
("PAR3252BR",32,52,0,"Panneau Ar","Brun",24,8,6.656,1,8,0),
("PAR3262BR",32,62,0,"Panneau Ar","Brun",27,8,7.936,1,8,0),
("PAR3280BR",32,80,0,"Panneau Ar","Brun",29,8,10.24,1,8,0),
("PAR42100BR",42,100,0,"Panneau Ar","Brun",24,8,16.8,1,8,0),
("PAR42120BR",42,120,0,"Panneau Ar","Brun",21,8,20.16,1,8,0),
("PAR4232BR",42,32,0,"Panneau Ar","Brun",25,8,5.376,1,8,0),
("PAR4242BR",42,42,0,"Panneau Ar","Brun",25,8,7.056,1,8,0),
("PAR4252BR",42,52,0,"Panneau Ar","Brun",26,8,8.736,1,8,0),
("PAR4262BR",42,62,0,"Panneau Ar","Brun",27,8,10.416,1,8,0),
("PAR4280BR",42,80,0,"Panneau Ar","Brun",26,8,13.44,1,8,0),
("PAR52100BR",52,100,0,"Panneau Ar","Brun",23,8,20.8,1,8,0),
("PAR52120BR",52,120,0,"Panneau Ar","Brun",24,8,24.96,1,8,0),
("PAR5232BR",52,32,0,"Panneau Ar","Brun",22,8,6.656,1,8,0),
("PAR5242BR",52,42,0,"Panneau Ar","Brun",20,8,8.736,1,8,0),
("PAR5252BR",52,52,0,"Panneau Ar","Brun",24,8,10.816,1,8,0),
("PAR5262BR",52,62,0,"Panneau Ar","Brun",28,8,12.896,1,8,0),
("PAR5280BR",52,80,0,"Panneau Ar","Brun",28,8,16.64,1,8,0),
("PAG3232BL",32,0,32,"Panneau GD","Blanc",45,16,5.12,2,16,0),
("PAG3242BL",32,0,42,"Panneau GD","Blanc",50,16,6.72,2,16,0),
("PAG3252BL",32,0,52,"Panneau GD","Blanc",41,16,8.32,2,16,0),
("PAG3262BL",32,0,62,"Panneau GD","Blanc",49,16,9.92,2,16,0),
("PAG4232BL",42,0,32,"Panneau GD","Blanc",49,16,6.72,2,16,0),
("PAG4242BL",42,0,42,"Panneau GD","Blanc",43,16,8.82,2,16,0),
("PAG4252BL",42,0,52,"Panneau GD","Blanc",45,16,10.92,2,16,0),
("PAG4262BL",42,0,62,"Panneau GD","Blanc",43,16,13.02,2,16,0),
("PAG5232BL",52,0,32,"Panneau GD","Blanc",50,16,8.32,2,16,0),
("PAG5242BL",52,0,42,"Panneau GD","Blanc",47,16,10.92,2,16,0),
("PAG5252BL",52,0,52,"Panneau GD","Blanc",47,16,13.52,2,16,0),
("PAG5262BL",52,0,62,"Panneau GD","Blanc",48,16,16.12,2,16,0),
("PAG3232BR",32,0,32,"Panneau GD","Brun",44,16,4.096,2,16,0),
("PAG3242BR",32,0,42,"Panneau GD","Brun",48,16,5.376,2,16,0),
("PAG3252BR",32,0,52,"Panneau GD","Brun",42,16,6.656,2,16,0),
("PAG3262BR",32,0,62,"Panneau GD","Brun",41,16,7.936,2,16,0),
("PAG4232BR",42,0,32,"Panneau GD","Brun",41,16,5.376,2,16,0),
("PAG4242BR",42,0,42,"Panneau GD","Brun",43,16,7.056,2,16,0),
("PAG4252BR",42,0,52,"Panneau GD","Brun",47,16,8.736,2,16,0),
("PAG4262BR",42,0,62,"Panneau GD","Brun",45,16,10.416,2,16,0),
("PAG5232BR",52,0,32,"Panneau GD","Brun",47,16,6.656,2,16,0),
("PAG5242BR",52,0,42,"Panneau GD","Brun",49,16,8.736,2,16,0),
("PAG5252BR",52,0,52,"Panneau GD","Brun",47,16,10.816,2,16,0),
("PAG5262BR",52,0,62,"Panneau GD","Brun",44,16,12.896,2,16,0),
("PAH32100BL",0,100,32,"Panneau HB","Blanc",49,16,16,2,16,0),
("PAH32120BL",0,120,32,"Panneau HB","Blanc",47,16,19.2,2,16,0),
("PAH3232BL",0,32,32,"Panneau HB","Blanc",50,16,5.12,2,16,0),
("PAH3242BL",0,42,32,"Panneau HB","Blanc",42,16,6.72,2,16,0),
("PAH3252BL",0,52,32,"Panneau HB","Blanc",41,16,8.32,2,16,0),
("PAH3262BL",0,62,32,"Panneau HB","Blanc",44,16,9.92,2,16,0),
("PAH3280BL",0,80,32,"Panneau HB","Blanc",48,16,12.8,2,16,0),
("PAH42100BL",0,100,42,"Panneau HB","Blanc",46,16,21,2,16,0),
("PAH42120BL",0,120,42,"Panneau HB","Blanc",41,16,25.2,2,16,0),
("PAH4232BL",0,32,42,"Panneau HB","Blanc",43,16,6.72,2,16,0),
("PAH4242BL",0,42,42,"Panneau HB","Blanc",40,16,8.82,2,16,0),
("PAH4252BL",0,52,42,"Panneau HB","Blanc",46,16,10.92,2,16,0),
("PAH4262BL",0,62,42,"Panneau HB","Blanc",45,16,13.02,2,16,0),
("PAH4280BL",0,80,42,"Panneau HB","Blanc",50,16,16.8,2,16,0),
("PAH52100BL",0,100,52,"Panneau HB","Blanc",49,16,26,2,16,0),
("PAH52120BL",0,120,52,"Panneau HB","Blanc",49,16,31.2,2,16,0),
("PAH5232BL",0,32,52,"Panneau HB","Blanc",45,16,8.32,2,16,0),
("PAH5242BL",0,42,52,"Panneau HB","Blanc",44,16,10.92,2,16,0),
("PAH5252BL",0,52,52,"Panneau HB","Blanc",42,16,13.52,2,16,0),
("PAH5262BL",0,62,52,"Panneau HB","Blanc",46,16,16.12,2,16,0),
("PAH5280BL",0,80,52,"Panneau HB","Blanc",41,16,20.8,2,16,0),
("PAH62100BL",0,100,62,"Panneau HB","Blanc",44,16,31,2,16,0),
("PAH62120BL",0,120,62,"Panneau HB","Blanc",43,16,37.2,2,16,0),
("PAH6232BL",0,32,62,"Panneau HB","Blanc",44,16,9.92,2,16,0),
("PAH6242BL",0,42,62,"Panneau HB","Blanc",44,16,13.02,2,16,0),
("PAH6252BL",0,52,62,"Panneau HB","Blanc",44,16,16.12,2,16,0),
("PAH6262BL",0,62,62,"Panneau HB","Blanc",46,16,19.22,2,16,0),
("PAH6280BL",0,80,62,"Panneau HB","Blanc",48,16,24.8,2,16,0),
("PAH32100BR",0,100,32,"Panneau HB","Brun",42,16,12.8,2,16,0),
("PAH32120BR",0,120,32,"Panneau HB","Brun",50,16,15.36,2,16,0),
("PAH3232BR",0,32,32,"Panneau HB","Brun",41,16,4.096,2,16,0),
("PAH3242BR",0,42,32,"Panneau HB","Brun",46,16,5.376,2,16,0),
("PAH3252BR",0,52,32,"Panneau HB","Brun",48,16,6.656,2,16,0),
("PAH3262BR",0,62,32,"Panneau HB","Brun",44,16,7.936,2,16,0),
("PAH3280BR",0,80,32,"Panneau HB","Brun",48,16,10.24,2,16,0),
("PAH42100BR",0,100,42,"Panneau HB","Brun",43,16,16.8,2,16,0),
("PAH42120BR",0,120,42,"Panneau HB","Brun",45,16,20.16,2,16,0),
("PAH4232BR",0,32,42,"Panneau HB","Brun",43,16,5.376,2,16,0),
("PAH4242BR",0,42,42,"Panneau HB","Brun",44,16,7.056,2,16,0),
("PAH4252BR",0,52,42,"Panneau HB","Brun",46,16,8.736,2,16,0),
("PAH4262BR",0,62,42,"Panneau HB","Brun",48,16,10.416,2,16,0),
("PAH4280BR",0,80,42,"Panneau HB","Brun",45,16,13.44,2,16,0),
("PAH52100BR",0,100,52,"Panneau HB","Brun",42,16,20.8,2,16,0),
("PAH52120BR",0,120,52,"Panneau HB","Brun",49,16,24.96,2,16,0),
("PAH5232BR",0,32,52,"Panneau HB","Brun",42,16,6.656,2,16,0),
("PAH5242BR",0,42,52,"Panneau HB","Brun",45,16,8.736,2,16,0),
("PAH5252BR",0,52,52,"Panneau HB","Brun",43,16,10.816,2,16,0),
("PAH5262BR",0,62,52,"Panneau HB","Brun",42,16,12.896,2,16,0),
("PAH5280BR",0,80,52,"Panneau HB","Brun",48,16,16.64,2,16,0),
("PAH62100BR",0,100,62,"Panneau HB","Brun",50,16,24.8,2,16,0),
("PAH62120BR",0,120,62,"Panneau HB","Brun",45,16,29.76,2,16,0),
("PAH6232BR",0,32,62,"Panneau HB","Brun",48,16,7.936,2,16,0),
("PAH6242BR",0,42,62,"Panneau HB","Brun",40,16,10.416,2,16,0),
("PAH6252BR",0,52,62,"Panneau HB","Brun",45,16,12.896,2,16,0),
("PAH6262BR",0,62,62,"Panneau HB","Brun",45,16,15.376,2,16,0),
("PAH6280BR",0,80,62,"Panneau HB","Brun",50,16,19.84,2,16,0),
("POR3232BL",32,32,0,"Porte ","Blanc",41,16,5.12,2,16,0),
("POR3242BL",32,42,0,"Porte ","Blanc",42,16,6.72,2,16,0),
("POR3252BL",32,52,0,"Porte ","Blanc",46,16,8.32,2,16,0),
("POR3262BL",32,62,0,"Porte ","Blanc",42,16,9.92,2,16,0),
("POR4232BL",42,32,0,"Porte ","Blanc",47,16,6.72,2,16,0),
("POR4242BL",42,42,0,"Porte ","Blanc",44,16,8.82,2,16,0),
("POR4252BL",42,52,0,"Porte ","Blanc",43,16,10.92,2,16,0),
("POR4262BL",42,62,0,"Porte ","Blanc",49,16,13.02,2,16,0),
("POR5232BL",52,32,0,"Porte ","Blanc",47,16,8.32,2,16,0),
("POR5242BL",52,42,0,"Porte ","Blanc",41,16,10.92,2,16,0),
("POR5252BL",52,52,0,"Porte ","Blanc",49,16,13.52,2,16,0),
("POR5262BL",52,62,0,"Porte ","Blanc",40,16,16.12,2,16,0),
("POR3232BR",32,32,0,"Porte ","Brun",46,16,5.12,2,16,0),
("POR3242BR",32,42,0,"Porte ","Brun",42,16,6.72,2,16,0),
("POR3252BR",32,52,0,"Porte ","Brun",47,16,8.32,2,16,0),
("POR3262BR",32,62,0,"Porte ","Brun",40,16,9.92,2,16,0),
("POR4232BR",42,32,0,"Porte ","Brun",46,16,6.72,2,16,0),
("POR4242BR",42,42,0,"Porte ","Brun",43,16,8.82,2,16,0),
("POR4252BR",42,52,0,"Porte ","Brun",46,16,10.92,2,16,0),
("POR4262BR",42,62,0,"Porte ","Brun",49,16,13.02,2,16,0),
("POR5232BR",52,32,0,"Porte ","Brun",43,16,8.32,2,16,0),
("POR5242BR",52,42,0,"Porte ","Brun",45,16,10.92,2,16,0),
("POR5252BR",52,52,0,"Porte ","Brun",42,16,13.52,2,16,0),
("POR5262BR",52,62,0,"Porte ","Brun",46,16,32.24,2,16,0),
("POR3232VE",32,32,0,"Porte ","Verre",46,16,10.24,2,16,0),
("POR3242VE",32,42,0,"Porte ","Verre",50,16,13.44,2,16,0),
("POR3252VE",32,52,0,"Porte ","Verre",42,16,16.64,2,16,0),
("POR3262VE",32,62,0,"Porte ","Verre",40,16,19.84,2,16,0),
("POR4232VE",42,32,0,"Porte ","Verre",43,16,13.44,2,16,0),
("POR4242VE",42,42,0,"Porte ","Verre",45,16,17.64,2,16,0),
("POR4252VE",42,52,0,"Porte ","Verre",45,16,21.84,2,16,0),
("POR4262VE",42,62,0,"Porte ","Verre",48,16,26.04,2,16,0),
("POR5232VE",52,32,0,"Porte ","Verre",46,16,16.64,2,16,0),
("POR5242VE",52,42,0,"Porte ","Verre",44,16,21.84,2,16,0),
("POR5252VE",52,52,0,"Porte ","Verre",47,16,27.04,2,16,0),
("POR5262VE",52,62,0,"Porte ","Verre",46,16,32.24,2,16,0),
("TAS27",32,0,0,"Tasseau",NULL,83,32,0.2,4,32,0),
("TAS37",42,0,0,"Tasseau",NULL,84,32,0.3,4,32,0),
("TAS47",52,0,0,"Tasseau",NULL,88,32,0.4,4,32,0),
("TRR100",0,100,0,"Traverse Ar",NULL,49,16,2,2,16,0),
("TRR120",0,120,0,"Traverse Ar",NULL,49,16,2.2,2,16,0),
("TRR32",0,32,0,"Traverse Ar",NULL,41,16,1,2,16,0),
("TRR42",0,42,0,"Traverse Ar",NULL,44,16,1.2,2,16,0),
("TRR52",0,52,0,"Traverse Ar",NULL,44,16,1.4,2,16,0),
("TRR62",0,62,0,"Traverse Ar",NULL,44,16,1.6,2,16,0),
("TRR80",0,80,0,"Traverse Ar",NULL,45,16,1.8,2,16,0),
("TRF100",0,100,0,"Traverse Av",NULL,48,16,2.2,2,16,0),
("TRF120",0,120,0,"Traverse Av",NULL,42,16,2.4,2,16,0),
("TRF32",0,32,0,"Traverse Av",NULL,45,16,1.5,2,16,0),
("TRF42",0,42,0,"Traverse Av",NULL,43,16,1.7,2,16,0),
("TRF52",0,52,0,"Traverse Av",NULL,44,16,1.8,2,16,0),
("TRF62",0,62,0,"Traverse Av",NULL,42,16,1.9,2,16,0),
("TRF80",0,80,0,"Traverse Av",NULL,44,16,2,2,16,0),
("TRG32",0,0,32,"Traverse GD",NULL,82,32,1,4,32,0),
("TRG42",0,0,42,"Traverse GD",NULL,83,32,1.2,4,32,0),
("TRG52",0,0,52,"Traverse GD",NULL,82,32,1.4,4,32,0),
("TRG62",0,0,62,"Traverse GD",NULL,82,32,1.6,4,32,0);

INSERT INTO kitbox.price(component_code, price, delivery_delay, id_supplier) VALUES 
("COR36BL", 0.3, 3, 1 ),
("COR46BL", 0.37, 12, 1 ),
("COR56BL", 0.46, 3, 1 ),
("COR72BL", 0.54, 12, 1 ),
("COR92BL", 0.72, 6, 1 ),
("COR108BL", 0.85, 7, 1 ),
("COR112BL", 0.89, 12, 1 ),
("COR138BL", 1.08, 11, 1 ),
("COR144BL", 1.08, 3, 1 ),
("COR168BL", 1.3, 5, 1 ),
("COR180BL", 1.33, 7, 1 ),
("COR184BL", 1.36, 3, 1 ),
("COR216BL", 1.63, 10, 1 ),
("COR224BL", 1.71, 7, 1 ),
("COR230BL", 1.71, 4, 1 ),
("COR252BL", 1.81, 9, 1 ),
("COR276BL", 2.16, 7, 1 ),
("COR280BL", 2.3, 10, 1 ),
("COR36BR", 0.24, 6, 1 ),
("COR46BR", 0.29, 4, 1 ),
("COR56BR", 0.38, 9, 1 ),
("COR72BR", 0.46, 12, 1 ),
("COR92BR", 0.58, 12, 1 ),
("COR108BR", 0.69, 7, 1 ),
("COR112BR", 0.74, 5, 1 ),
("COR138BR", 0.85, 12, 1 ),
("COR144BR", 0.82, 11, 1 ),
("COR168BR", 1.08, 4, 1 ),
("COR180BR", 1.11, 11, 1 ),
("COR184BR", 1.2, 5, 1 ),
("COR216BR", 1.24, 11, 1 ),
("COR224BR", 1.46, 9, 1 ),
("COR230BR", 1.44, 6, 1 ),
("COR252BR", 1.53, 10, 1 ),
("COR276BR", 1.6, 13, 1 ),
("COR280BR", 1.84, 10, 1 ),
("COR36GL", 0.3, 7, 1 ),
("COR46GL", 0.37, 10, 1 ),
("COR56GL", 0.48, 8, 1 ),
("COR72GL", 0.58, 4, 1 ),
("COR92GL", 0.75, 5, 1 ),
("COR108GL", 0.84, 6, 1 ),
("COR112GL", 0.94, 8, 1 ),
("COR138GL", 1.02, 6, 1 ),
("COR144GL", 1.13, 12, 1 ),
("COR168GL", 1.27, 11, 1 ),
("COR180GL", 1.33, 9, 1 ),
("COR184GL", 1.46, 11, 1 ),
("COR216GL", 1.71, 10, 1 ),
("COR224GL", 1.69, 4, 1 ),
("COR230GL", 1.73, 9, 1 ),
("COR252GL", 1.84, 3, 1 ),
("COR276GL", 2.03, 7, 1 ),
("COR280GL", 2.26, 13, 1 ),
("COR36NR", 0.21, 7, 1 ),
("COR46NR", 0.26, 9, 1 ),
("COR56NR", 0.34, 6, 1 ),
("COR72NR", 0.39, 13, 1 ),
("COR92NR", 0.51, 10, 1 ),
("COR108NR", 0.55, 13, 1 ),
("COR112NR", 0.62, 6, 1 ),
("COR138NR", 0.75, 11, 1 ),
("COR144NR", 0.8, 5, 1 ),
("COR168NR", 0.99, 11, 1 ),
("COR180NR", 0.94, 9, 1 ),
("COR184NR", 1.04, 6, 1 ),
("COR216NR", 1.17, 9, 1 ),
("COR224NR", 1.25, 6, 1 ),
("COR230NR", 1.28, 11, 1 ),
("COR252NR", 1.27, 9, 1 ),
("COR276NR", 1.52, 7, 1 ),
("COR280NR", 1.49, 8, 1 ),
("COUPEL", 0.004, 13, 1 ),
("COR50BLDEC", 0.69, 3, 1 ),
("COR50BRDEC", 0.57, 9, 1 ),
("COR50GLDEC", 0.72, 8, 1 ),
("COR50NRDEC", 0.51, 6, 1 ),
("COR75BLDEC", 0.81, 12, 1 ),
("COR75BRDEC", 0.69, 12, 1 ),
("COR75GLDEC", 0.87, 4, 1 ),
("COR75NRDEC", 0.59, 13, 1 ),
("COR100BLDEC", 1.08, 6, 1 ),
("COR100BRDEC", 0.87, 12, 1 ),
("COR100GLDEC", 1.13, 5, 1 ),
("COR100NRDEC", 0.77, 10, 1 ),
("COR125BLDEC", 1.28, 7, 1 ),
("COR125BRDEC", 1.04, 7, 1 ),
("COR125GLDEC", 1.26, 6, 1 ),
("COR125NRDEC", 0.83, 13, 1 ),
("COR150BLDEC", 1.62, 11, 1 ),
("COR150BRDEC", 1.28, 12, 1 ),
("COR150GLDEC", 1.53, 6, 1 ),
("COR150NRDEC", 1.13, 11, 1 ),
("COR175BLDEC", 1.95, 5, 1 ),
("COR175BRDEC", 1.62, 4, 1 ),
("COR175GLDEC", 1.91, 11, 1 ),
("COR175NRDEC", 1.49, 11, 1 ),
("COR200BLDEC", 2.04, 3, 1 ),
("COR200BRDEC", 1.8, 5, 1 ),
("COR200GLDEC", 2.19, 11, 1 ),
("COR200NRDEC", 1.56, 6, 1 ),
("COR225BLDEC", 2.45, 10, 1 ),
("COR225BRDEC", 1.86, 11, 1 ),
("COR225GLDEC", 2.57, 10, 1 ),
("COR225NRDEC", 1.76, 9, 1 ),
("COR250BLDEC", 2.72, 9, 1 ),
("COR250BRDEC", 2.3, 10, 1 ),
("COR250GLDEC", 2.76, 3, 1 ),
("COR250NRDEC", 1.91, 9, 1 ),
("COR275BLDEC", 3.24, 7, 1 ),
("COR275BRDEC", 2.4, 13, 1 ),
("COR275GLDEC", 3.05, 7, 1 ),
("COR275NRDEC", 2.28, 7, 1 ),
("COR300BLDEC", 3.45, 10, 1 ),
("COR300BRDEC", 2.76, 10, 1 ),
("COR300GLDEC", 3.39, 13, 1 ),
("COR300NRDEC", 2.24, 8, 1 ),
("COR325BLDEC", 3.45, 10, 1 ),
("COR325BRDEC", 2.76, 10, 1 ),
("COR325GLDEC", 3.39, 13, 1 ),
("COR325NRDEC", 2.24, 8, 1 ),
("COR350BLDEC", 3.45, 10, 1 ),
("COR350BRDEC", 2.76, 10, 1 ),
("COR350GLDEC", 3.39, 13, 1 ),
("COR350NRDEC", 2.24, 8, 1 ),
("COR375BLDEC", 3.45, 10, 1 ),
("COR375BRDEC", 2.76, 10, 1 ),
("COR375GLDEC", 3.39, 13, 1 ),
("COR375NRDEC", 2.24, 8, 1 ),
("PAR32100BL", 12.92, 13, 1 ),
("PAR32120BL", 15.54, 6, 1 ),
("PAR3232BL", 4.24, 10, 1 ),
("PAR3242BL", 6, 7, 1 ),
("PAR3252BL", 7.36, 7, 1 ),
("PAR3262BL", 8.88, 12, 1 ),
("PAR3280BL", 10.43, 10, 1 ),
("PAR42100BL", 22.63, 6, 1 ),
("PAR42120BL", 25.98, 7, 1 ),
("PAR4232BL", 7.1, 10, 1 ),
("PAR4242BL", 9.82, 4, 1 ),
("PAR4252BL", 11.72, 7, 1 ),
("PAR4262BL", 13.69, 6, 1 ),
("PAR4280BL", 16.86, 6, 1 ),
("PAR52100BL", 21.89, 9, 1 ),
("PAR52120BL", 26.99, 6, 1 ),
("PAR5232BL", 7.32, 5, 1 ),
("PAR5242BL", 9.11, 9, 1 ),
("PAR5252BL", 10.98, 9, 1 ),
("PAR5262BL", 14.09, 11, 1 ),
("PAR5280BL", 16.91, 13, 1 ),
("PAR32100BR", 11.31, 11, 1 ),
("PAR32120BR", 13.31, 5, 1 ),
("PAR3232BR", 3.29, 7, 1 ),
("PAR3242BR", 4.46, 8, 1 ),
("PAR3252BR", 5.65, 4, 1 ),
("PAR3262BR", 6.43, 7, 1 ),
("PAR3280BR", 8.44, 3, 1 ),
("PAR42100BR", 13.61, 13, 1 ),
("PAR42120BR", 16.16, 10, 1 ),
("PAR4232BR", 4.66, 13, 1 ),
("PAR4242BR", 5.73, 10, 1 ),
("PAR4252BR", 7.24, 10, 1 ),
("PAR4262BR", 9.09, 5, 1 ),
("PAR4280BR", 11.33, 4, 1 ),
("PAR52100BR", 17.2, 7, 1 ),
("PAR52120BR", 19.98, 9, 1 ),
("PAR5232BR", 5.99, 9, 1 ),
("PAR5242BR", 7.48, 5, 1 ),
("PAR5252BR", 9.26, 8, 1 ),
("PAR5262BR", 10.67, 8, 1 ),
("PAR5280BR", 14.23, 13, 1 ),
("PAG3232BL", 4.53, 13, 1 ),
("PAG3242BL", 5.82, 10, 1 ),
("PAG3252BL", 6.9, 7, 1 ),
("PAG3262BL", 8.31, 5, 1 ),
("PAG4232BL", 5.46, 11, 1 ),
("PAG4242BL", 7.65, 6, 1 ),
("PAG4252BL", 9.16, 5, 1 ),
("PAG4262BL", 10.93, 7, 1 ),
("PAG5232BL", 6.83, 9, 1 ),
("PAG5242BL", 9.32, 9, 1 ),
("PAG5252BL", 11.51, 6, 1 ),
("PAG5262BL", 14.35, 12, 1 ),
("PAG3232BR", 3.6, 9, 1 ),
("PAG3242BR", 4.47, 6, 1 ),
("PAG3252BR", 5.49, 7, 1 ),
("PAG3262BR", 6.49, 13, 1 ),
("PAG4232BR", 4.42, 9, 1 ),
("PAG4242BR", 6.2, 9, 1 ),
("PAG4252BR", 7.05, 8, 1 ),
("PAG4262BR", 9.29, 4, 1 ),
("PAG5232BR", 5.39, 5, 1 ),
("PAG5242BR", 7.36, 3, 1 ),
("PAG5252BR", 8.81, 11, 1 ),
("PAG5262BR", 11, 11, 1 ),
("PAH32100BL", 12.97, 6, 1 ),
("PAH32120BL", 16.99, 6, 1 ),
("PAH3232BL", 4.31, 7, 1 ),
("PAH3242BL", 5.41, 4, 1 ),
("PAH3252BL", 6.66, 11, 1 ),
("PAH3262BL", 8.49, 8, 1 ),
("PAH3280BL", 10.73, 11, 1 ),
("PAH42100BL", 17.7, 6, 1 ),
("PAH42120BL", 22.21, 13, 1 ),
("PAH4232BL", 5.71, 3, 1 ),
("PAH4242BL", 7.33, 4, 1 ),
("PAH4252BL", 9.72, 7, 1 ),
("PAH4262BL", 10.91, 11, 1 ),
("PAH4280BL", 13.6, 7, 1 ),
("PAH52100BL", 23.33, 4, 1 ),
("PAH52120BL", 28, 6, 1 ),
("PAH5232BL", 7.25, 5, 1 ),
("PAH5242BL", 9.46, 12, 1 ),
("PAH5252BL", 11.25, 8, 1 ),
("PAH5262BL", 13.65, 12, 1 ),
("PAH5280BL", 17.55, 7, 1 ),
("PAH62100BL", 26.08, 4, 1 ),
("PAH62120BL", 33.13, 6, 1 ),
("PAH6232BL", 8.92, 11, 1 ),
("PAH6242BL", 11.02, 6, 1 ),
("PAH6252BL", 14.1, 6, 1 ),
("PAH6262BL", 15.86, 12, 1 ),
("PAH6280BL", 22.2, 5, 1 ),
("PAH32100BR", 11.29, 10, 1 ),
("PAH32120BR", 13.3, 9, 1 ),
("PAH3232BR", 3.34, 9, 1 ),
("PAH3242BR", 4.3, 7, 1 ),
("PAH3252BR", 5.67, 11, 1 ),
("PAH3262BR", 6.92, 4, 1 ),
("PAH3280BR", 8.6, 8, 1 ),
("PAH42100BR", 15.01, 4, 1 ),
("PAH42120BR", 17.65, 8, 1 ),
("PAH4232BR", 4.41, 10, 1 ),
("PAH4242BR", 5.92, 9, 1 ),
("PAH4252BR", 7.07, 5, 1 ),
("PAH4262BR", 9.28, 6, 1 ),
("PAH4280BR", 11.02, 12, 1 ),
("PAH52100BR", 17.94, 12, 1 ),
("PAH52120BR", 20.67, 6, 1 ),
("PAH5232BR", 5.44, 8, 1 ),
("PAH5242BR", 7.03, 7, 1 ),
("PAH5252BR", 9.67, 12, 1 ),
("PAH5262BR", 10.83, 6, 1 ),
("PAH5280BR", 14.27, 7, 1 ),
("PAH62100BR", 21.16, 12, 1 ),
("PAH62120BR", 26.55, 12, 1 ),
("PAH6232BR", 6.52, 5, 1 ),
("PAH6242BR", 9.12, 11, 1 ),
("PAH6252BR", 11.56, 10, 1 ),
("PAH6262BR", 13.41, 7, 1 ),
("PAH6280BR", 17.8, 7, 1 ),
("POR3232BL", 4.31, 7, 1 ),
("POR3242BL", 5.6, 10, 1 ),
("POR3252BL", 6.82, 12, 1 ),
("POR3262BL", 7.95, 12, 1 ),
("POR4232BL", 5.69, 6, 1 ),
("POR4242BL", 7.23, 6, 1 ),
("POR4252BL", 9.56, 10, 1 ),
("POR4262BL", 11.16, 5, 1 ),
("POR5232BL", 7.25, 7, 1 ),
("POR5242BL", 9.12, 12, 1 ),
("POR5252BL", 11.01, 11, 1 ),
("POR5262BL", 13.86, 4, 1 ),
("POR3232BR", 4.14, 4, 1 ),
("POR3242BR", 5.98, 7, 1 ),
("POR3252BR", 7.31, 5, 1 ),
("POR3262BR", 8.4, 7, 1 ),
("POR4232BR", 5.96, 11, 1 ),
("POR4242BR", 7.41, 12, 1 ),
("POR4252BR", 9.76, 4, 1 ),
("POR4262BR", 11.54, 5, 1 ),
("POR5232BR", 7.15, 11, 1 ),
("POR5242BR", 8.76, 3, 1 ),
("POR5252BR", 11.66, 6, 1 ),
("POR5262BR", 25.99, 11, 1 ),
("POR3232VE", 8.79, 11, 1 ),
("POR3242VE", 11.23, 5, 1 ),
("POR3252VE", 13.48, 11, 1 ),
("POR3262VE", 17.74, 6, 1 ),
("POR4232VE", 11.57, 10, 1 ),
("POR4242VE", 15.27, 10, 1 ),
("POR4252VE", 19.47, 5, 1 ),
("POR4262VE", 20.85, 9, 1 ),
("POR5232VE", 13.7, 13, 1 ),
("POR5242VE", 18.81, 12, 1 ),
("POR5252VE", 23.04, 12, 1 ),
("POR5262VE", 27.45, 8, 1 ),
("TAS27", 0.17, 10, 1 ),
("TAS37", 0.25, 4, 1 ),
("TAS47", 0.34, 10, 1 ),
("TRR100", 1.67, 10, 1 ),
("TRR120", 1.88, 4, 1 ),
("TRR32", 0.89, 8, 1 ),
("TRR42", 0.98, 10, 1 ),
("TRR52", 1.2, 6, 1 ),
("TRR62", 1.35, 12, 1 ),
("TRR80", 1.52, 3, 1 ),
("TRF100", 1.93, 5, 1 ),
("TRF120", 1.98, 5, 1 ),
("TRF32", 1.32, 8, 1 ),
("TRF42", 1.49, 8, 1 ),
("TRF52", 1.53, 6, 1 ),
("TRF62", 1.63, 8, 1 ),
("TRF80", 1.61, 4, 1 ),
("TRG32", 0.9, 9, 1 ),
("TRG42", 1.01, 4, 1 ),
("TRG52", 1.21, 12, 1 ),
("TRG62", 1.43, 8, 1 );

INSERT INTO kitbox.price(component_code, price, delivery_delay, id_supplier) VALUES 
("COR36BL", 0.23, 9, 2 ),
("COR46BL", 0.3, 9, 2 ),
("COR56BL", 0.35, 9, 2 ),
("COR72BL", 0.45, 18, 2 ),
("COR92BL", 0.6, 18, 2 ),
("COR108BL", 0.65, 13, 2 ),
("COR112BL", 0.74, 13, 2 ),
("COR138BL", 0.8, 14, 2 ),
("COR144BL", 0.85, 14, 2 ),
("COR168BL", 1.06, 12, 2 ),
("COR180BL", 1.02, 9, 2 ),
("COR184BL", 1.11, 16, 2 ),
("COR216BL", 1.3, 14, 2 ),
("COR224BL", 1.33, 10, 2 ),
("COR230BL", 1.42, 15, 2 ),
("COR252BL", 1.4, 17, 2 ),
("COR276BL", 1.64, 14, 2 ),
("COR280BL", 1.75, 10, 2 ),
("COR36BR", 0.18, 16, 2 ),
("COR46BR", 0.24, 9, 2 ),
("COR56BR", 0.27, 13, 2 ),
("COR72BR", 0.37, 12, 2 ),
("COR92BR", 0.43, 8, 2 ),
("COR108BR", 0.48, 11, 2 ),
("COR112BR", 0.54, 11, 2 ),
("COR138BR", 0.64, 15, 2 ),
("COR144BR", 0.68, 13, 2 ),
("COR168BR", 0.79, 16, 2 ),
("COR180BR", 0.8, 9, 2 ),
("COR184BR", 0.83, 17, 2 ),
("COR216BR", 1.05, 8, 2 ),
("COR224BR", 1.14, 11, 2 ),
("COR230BR", 1.14, 13, 2 ),
("COR252BR", 1.21, 17, 2 ),
("COR276BR", 1.28, 13, 2 ),
("COR280BR", 1.4, 11, 2 ),
("COR36GL", 0.24, 14, 2 ),
("COR46GL", 0.27, 14, 2 ),
("COR56GL", 0.37, 15, 2 ),
("COR72GL", 0.4, 13, 2 ),
("COR92GL", 0.52, 12, 2 ),
("COR108GL", 0.66, 14, 2 ),
("COR112GL", 0.68, 14, 2 ),
("COR138GL", 0.88, 11, 2 ),
("COR144GL", 0.84, 9, 2 ),
("COR168GL", 1.05, 15, 2 ),
("COR180GL", 1.05, 9, 2 ),
("COR184GL", 1.11, 17, 2 ),
("COR216GL", 1.21, 13, 2 ),
("COR224GL", 1.38, 16, 2 ),
("COR230GL", 1.39, 15, 2 ),
("COR252GL", 1.54, 13, 2 ),
("COR276GL", 1.53, 17, 2 ),
("COR280GL", 1.66, 15, 2 ),
("COR36NR", 0.15, 17, 2 ),
("COR46NR", 0.2, 11, 2 ),
("COR56NR", 0.27, 12, 2 ),
("COR72NR", 0.31, 13, 2 ),
("COR92NR", 0.38, 14, 2 ),
("COR108NR", 0.44, 15, 2 ),
("COR112NR", 0.45, 12, 2 ),
("COR138NR", 0.55, 13, 2 ),
("COR144NR", 0.62, 11, 2 ),
("COR168NR", 0.73, 16, 2 ),
("COR180NR", 0.7, 11, 2 ),
("COR184NR", 0.75, 17, 2 ),
("COR216NR", 0.92, 13, 2 ),
("COR224NR", 0.88, 13, 2 ),
("COR230NR", 0.96, 17, 2 ),
("COR252NR", 0.98, 16, 2 ),
("COR276NR", 1.18, 12, 2 ),
("COR280NR", 1.24, 15, 2 ),
("COUPEL", 0.0035, 13, 2 ),
("COR50BLDEC", 0.42, 9, 2 ),
("COR50BRDEC", 0.32, 13, 2 ),
("COR50GLDEC", 0.44, 15, 2 ),
("COR50NRDEC", 0.32, 12, 2 ),
("COR75BLDEC", 0.54, 18, 2 ),
("COR75BRDEC", 0.44, 12, 2 ),
("COR75GLDEC", 0.48, 13, 2 ),
("COR75NRDEC", 0.37, 13, 2 ),
("COR100BLDEC", 0.72, 18, 2 ),
("COR100BRDEC", 0.52, 8, 2 ),
("COR100GLDEC", 0.62, 12, 2 ),
("COR100NRDEC", 0.46, 14, 2 ),
("COR125BLDEC", 0.78, 13, 2 ),
("COR125BRDEC", 0.58, 11, 2 ),
("COR125GLDEC", 0.79, 14, 2 ),
("COR125NRDEC", 0.53, 15, 2 ),
("COR150BLDEC", 0.96, 14, 2 ),
("COR150BRDEC", 0.77, 15, 2 ),
("COR150GLDEC", 1.06, 11, 2 ),
("COR150NRDEC", 0.66, 13, 2 ),
("COR175BLDEC", 1.27, 12, 2 ),
("COR175BRDEC", 0.95, 16, 2 ),
("COR175GLDEC", 1.26, 15, 2 ),
("COR175NRDEC", 0.88, 16, 2 ),
("COR200BLDEC", 1.33, 16, 2 ),
("COR200BRDEC", 1, 17, 2 ),
("COR200GLDEC", 1.33, 17, 2 ),
("COR200NRDEC", 0.9, 17, 2 ),
("COR225BLDEC", 1.56, 14, 2 ),
("COR225BRDEC", 1.26, 8, 2 ),
("COR225GLDEC", 1.45, 13, 2 ),
("COR225NRDEC", 1.1, 13, 2 ),
("COR250BLDEC", 1.68, 17, 2 ),
("COR250BRDEC", 1.45, 17, 2 ),
("COR250GLDEC", 1.85, 13, 2 ),
("COR250NRDEC", 1.18, 16, 2 ),
("COR275BLDEC", 1.97, 14, 2 ),
("COR275BRDEC", 1.54, 13, 2 ),
("COR275GLDEC", 1.84, 17, 2 ),
("COR275NRDEC", 1.42, 12, 2 ),
("COR300BLDEC", 2.1, 10, 2 ),
("COR300BRDEC", 1.68, 11, 2 ),
("COR300GLDEC", 1.99, 15, 2 ),
("COR300NRDEC", 1.49, 15, 2 ),
("COR325BLDEC", 2.1, 10, 2 ),
("COR325BRDEC", 1.68, 11, 2 ),
("COR325GLDEC", 1.99, 15, 2 ),
("COR325NRDEC", 1.49, 15, 2 ),
("COR350BLDEC", 2.1, 10, 2 ),
("COR350BRDEC", 1.68, 11, 2 ),
("COR350GLDEC", 1.99, 15, 2 ),
("COR350NRDEC", 1.49, 15, 2 ),
("COR375BLDEC", 2.1, 10, 2 ),
("COR375BRDEC", 1.68, 11, 2 ),
("COR375GLDEC", 1.99, 15, 2 ),
("COR375NRDEC", 1.49, 15, 2 ),
("PAR32100BL", 9.81, 14, 2 ),
("PAR32120BL", 12.31, 10, 2 ),
("PAR3232BL", 3.34, 14, 2 ),
("PAR3242BL", 4.36, 13, 2 ),
("PAR3252BL", 5.51, 14, 2 ),
("PAR3262BL", 6.22, 17, 2 ),
("PAR3280BL", 8.17, 12, 2 ),
("PAR42100BL", 16.3, 11, 2 ),
("PAR42120BL", 21.59, 16, 2 ),
("PAR4232BL", 5.71, 14, 2 ),
("PAR4242BL", 7.03, 9, 2 ),
("PAR4252BL", 8.48, 13, 2 ),
("PAR4262BL", 10.64, 17, 2 ),
("PAR4280BL", 13.83, 8, 2 ),
("PAR52100BL", 17.85, 9, 2 ),
("PAR52120BL", 20.81, 18, 2 ),
("PAR5232BL", 5.33, 17, 2 ),
("PAR5242BL", 7.52, 16, 2 ),
("PAR5252BL", 8.45, 14, 2 ),
("PAR5262BL", 10.72, 15, 2 ),
("PAR5280BL", 13.57, 18, 2 ),
("PAR32100BR", 8.93, 11, 2 ),
("PAR32120BR", 10.09, 17, 2 ),
("PAR3232BR", 2.46, 16, 2 ),
("PAR3242BR", 3.34, 13, 2 ),
("PAR3252BR", 4.28, 10, 2 ),
("PAR3262BR", 5.51, 8, 2 ),
("PAR3280BR", 6.16, 11, 2 ),
("PAR42100BR", 10.12, 15, 2 ),
("PAR42120BR", 13.25, 10, 2 ),
("PAR4232BR", 3.53, 17, 2 ),
("PAR4242BR", 4.71, 15, 2 ),
("PAR4252BR", 5.68, 11, 2 ),
("PAR4262BR", 6.75, 17, 2 ),
("PAR4280BR", 9.41, 17, 2 ),
("PAR52100BR", 14.07, 13, 2 ),
("PAR52120BR", 16.12, 10, 2 ),
("PAR5232BR", 4.11, 10, 2 ),
("PAR5242BR", 5.64, 14, 2 ),
("PAR5252BR", 6.66, 10, 2 ),
("PAR5262BR", 8.46, 15, 2 ),
("PAR5280BR", 10.31, 17, 2 ),
("PAG3232BL", 3.43, 12, 2 ),
("PAG3242BL", 4.12, 12, 2 ),
("PAG3252BL", 5.62, 10, 2 ),
("PAG3262BL", 6.31, 10, 2 ),
("PAG4232BL", 4.3, 9, 2 ),
("PAG4242BL", 5.79, 14, 2 ),
("PAG4252BL", 7.09, 10, 2 ),
("PAG4262BL", 9.06, 17, 2 ),
("PAG5232BL", 5.71, 11, 2 ),
("PAG5242BL", 7.05, 12, 2 ),
("PAG5252BL", 9.44, 9, 2 ),
("PAG5262BL", 10.43, 17, 2 ),
("PAG3232BR", 2.52, 17, 2 ),
("PAG3242BR", 3.28, 10, 2 ),
("PAG3252BR", 4.25, 11, 2 ),
("PAG3262BR", 4.9, 9, 2 ),
("PAG4232BR", 3.58, 15, 2 ),
("PAG4242BR", 4.84, 8, 2 ),
("PAG4252BR", 5.98, 14, 2 ),
("PAG4262BR", 6.91, 15, 2 ),
("PAG5232BR", 4.62, 14, 2 ),
("PAG5242BR", 5.55, 16, 2 ),
("PAG5252BR", 7.27, 9, 2 ),
("PAG5262BR", 8.75, 13, 2 ),
("PAH32100BL", 11.07, 15, 2 ),
("PAH32120BL", 12.39, 11, 2 ),
("PAH3232BL", 3.33, 14, 2 ),
("PAH3242BL", 4.33, 17, 2 ),
("PAH3252BL", 5.31, 17, 2 ),
("PAH3262BL", 6.31, 14, 2 ),
("PAH3280BL", 8.22, 13, 2 ),
("PAH42100BL", 14.3, 10, 2 ),
("PAH42120BL", 16.22, 10, 2 ),
("PAH4232BL", 4.55, 17, 2 ),
("PAH4242BL", 5.95, 18, 2 ),
("PAH4252BL", 6.95, 13, 2 ),
("PAH4262BL", 8.55, 10, 2 ),
("PAH4280BL", 11.46, 12, 2 ),
("PAH52100BL", 18.15, 15, 2 ),
("PAH52120BL", 20.47, 16, 2 ),
("PAH5232BL", 5.06, 8, 2 ),
("PAH5242BL", 7.32, 12, 2 ),
("PAH5252BL", 8.46, 14, 2 ),
("PAH5262BL", 11.02, 12, 2 ),
("PAH5280BL", 12.67, 12, 2 ),
("PAH62100BL", 20.87, 16, 2 ),
("PAH62120BL", 25.73, 17, 2 ),
("PAH6232BL", 6.76, 14, 2 ),
("PAH6242BL", 8.38, 17, 2 ),
("PAH6252BL", 9.68, 12, 2 ),
("PAH6262BL", 12.92, 14, 2 ),
("PAH6280BL", 15.1, 10, 2 ),
("PAH32100BR", 7.77, 9, 2 ),
("PAH32120BR", 10.73, 14, 2 ),
("PAH3232BR", 2.64, 14, 2 ),
("PAH3242BR", 3.61, 16, 2 ),
("PAH3252BR", 4.51, 15, 2 ),
("PAH3262BR", 4.94, 11, 2 ),
("PAH3280BR", 6.2, 17, 2 ),
("PAH42100BR", 10.23, 8, 2 ),
("PAH42120BR", 12.4, 15, 2 ),
("PAH4232BR", 3.34, 9, 2 ),
("PAH4242BR", 4.7, 11, 2 ),
("PAH4252BR", 5.87, 16, 2 ),
("PAH4262BR", 7.11, 16, 2 ),
("PAH4280BR", 8.22, 10, 2 ),
("PAH52100BR", 14.2, 14, 2 ),
("PAH52120BR", 16.37, 8, 2 ),
("PAH5232BR", 4.12, 10, 2 ),
("PAH5242BR", 5.48, 15, 2 ),
("PAH5252BR", 6.51, 14, 2 ),
("PAH5262BR", 8.75, 17, 2 ),
("PAH5280BR", 10.38, 9, 2 ),
("PAH62100BR", 15.11, 17, 2 ),
("PAH62120BR", 18.22, 9, 2 ),
("PAH6232BR", 5.12, 17, 2 ),
("PAH6242BR", 6.39, 16, 2 ),
("PAH6252BR", 8.04, 10, 2 ),
("PAH6262BR", 10.41, 12, 2 ),
("PAH6280BR", 12.21, 18, 2 ),
("POR3232BL", 3.14, 8, 2 ),
("POR3242BL", 4.35, 14, 2 ),
("POR3252BL", 5.53, 13, 2 ),
("POR3262BL", 6.88, 14, 2 ),
("POR4232BL", 4.2, 17, 2 ),
("POR4242BL", 5.84, 13, 2 ),
("POR4252BL", 6.67, 10, 2 ),
("POR4262BL", 8.23, 11, 2 ),
("POR5232BL", 5.23, 16, 2 ),
("POR5242BL", 6.96, 14, 2 ),
("POR5252BL", 8.29, 10, 2 ),
("POR5262BL", 10.95, 13, 2 ),
("POR3232BR", 3.45, 8, 2 ),
("POR3242BR", 4.68, 13, 2 ),
("POR3252BR", 5.4, 14, 2 ),
("POR3262BR", 5.97, 17, 2 ),
("POR4232BR", 4.43, 11, 2 ),
("POR4242BR", 5.75, 15, 2 ),
("POR4252BR", 7.15, 12, 2 ),
("POR4262BR", 7.83, 17, 2 ),
("POR5232BR", 5.24, 13, 2 ),
("POR5242BR", 6.97, 10, 2 ),
("POR5252BR", 8.43, 12, 2 ),
("POR5262BR", 21.36, 10, 2 ),
("POR3232VE", 6.3, 16, 2 ),
("POR3242VE", 9, 14, 2 ),
("POR3252VE", 11.53, 15, 2 ),
("POR3262VE", 13.05, 10, 2 ),
("POR4232VE", 8.72, 18, 2 ),
("POR4242VE", 10.7, 15, 2 ),
("POR4252VE", 14.89, 15, 2 ),
("POR4262VE", 18.22, 15, 2 ),
("POR5232VE", 11.12, 9, 2 ),
("POR5242VE", 14.55, 15, 2 ),
("POR5252VE", 17.02, 11, 2 ),
("POR5262VE", 20.61, 17, 2 ),
("TAS27", 0.13, 14, 2 ),
("TAS37", 0.19, 8, 2 ),
("TAS47", 0.24, 10, 2 ),
("TRR100", 1.26, 10, 2 ),
("TRR120", 1.38, 10, 2 ),
("TRR32", 0.69, 10, 2 ),
("TRR42", 0.75, 10, 2 ),
("TRR52", 0.94, 10, 2 ),
("TRR62", 1.11, 10, 2 ),
("TRR80", 1.16, 11, 2 ),
("TRF100", 1.48, 12, 2 ),
("TRF120", 1.63, 8, 2 ),
("TRF32", 1.05, 16, 2 ),
("TRF42", 1.17, 14, 2 ),
("TRF52", 1.2, 9, 2 ),
("TRF62", 1.28, 16, 2 ),
("TRF80", 1.21, 12, 2 ),
("TRG32", 0.63, 11, 2 ),
("TRG42", 0.76, 17, 2 ),
("TRG52", 0.85, 14, 2 ),
("TRG62", 0.98, 12, 2 );


