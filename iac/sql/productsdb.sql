use productsdb

DROP TABLE IF EXISTS Brands

CREATE TABLE Brands
(
    Id int NOT NULL,
    Name nvarchar(255) NULL,
    CONSTRAINT PK_Brands PRIMARY KEY(Id)
)

INSERT INTO Brands
VALUES
    (1, 'ElctroDrill'),
    (2, 'Home & Pro tools'),
    (3, 'ProSaws'),
    (4, 'Drills Co')

DROP TABLE IF EXISTS Features

CREATE TABLE Features
(
    Id int NOT NULL,
    Title nvarchar(255) NULL,
    Description nvarchar(max) NULL,
    ProductItemId int NULL,
    CONSTRAINT PK_Features PRIMARY KEY(Id)
)

INSERT INTO Features
Values
    (1,'20 Litre','Create delicious meals with this 800 W manual microwave with a 20 Litre capacity',1),
    (2,'Multipower','Six power levels including a defrost setting offers variety for your cooking requirements',1),
    (3,'3 years guarantee','3 years guarantee',1),
    (4,'Key features','20Litre capacity (0.7cu.ft) 800W microwave output 11 microwave power levels 99min timer Cooking end signal Auto cook menus Defrost setting Glass turntable Mirror door',1),
    (5,'Triple Distribution System','Meaning a more even and effective distribution of heat. Easytronics dial control',1),
    (6,'Low Noise','Thermoelectric technology is almost silent, so your kitchen stays quiet',2),
    (7,'Stylish','Stylish American Style, Side by side Fridge freezer with energy rating A+',2),
    (8,'Great capacity','510 litre capacity - holds 28 bags of food shopping',2),
    (9,'Double Hotplate','Enjoy the bonus feature of including 2 ceramic hotplates, which are positioned on the top of the mini oven and are suitable for use with any kind of pot, pan, and frying pan for boiling, steaming, warming, or frying.',3),
    (10,'2-year warranty','Shop with confidence. Your Oven with is covered by a 2 year manufacturer''s warranty',3),
    (11,'9k capacity','9kg drum capacity',4),
    (12,'A+++','A+++ energy rating',4),
    (13,'1600rpm','1600rpm max spin speed',5),
    (14,'15 wash programmes','15 wash programmes',5),
    (15,'Silver','Colour Silver',6),
    (16,'Eco-Friendly','Eco-Friendly',6),
    (17,'Size','Approx. 27x27cm',6),
    (18,'Capacity','141 Litres Fridge Capacity',7),
    (19,'Interface',' inlet: G1 / 2, outlet: G1 / 4.',8),
    (20,'Leakproof','The shower arm diverter is made by top premium brass with disc cartridge for leakproof and durability warranty',9),
    (21,'Pinhole','The pinhole is out of the water, the water is slender and soft, and there is no pain in the body. ',10),
    (22,'Interface','The interface is suitable for most home use, hoses, showers, and interfaces are 2cm in diameter. It is suitable for all types of water heaters. ',10),
    (23,'Portable battery','Battery powered portable bidet (rechargeable) can be taken anywhere' ,11),
    (24,'10 wash cycles','Minimum 50 wash cycles between charge & 10 wash cycles per 1.5 litre reservoir' ,11),
    (25,'Remote handset','Operates from a simple remote handset' ,11),
    (26,'Multifunction','Not only ideal for dog shower in bathroom, but also can be used as handheld bidet for personal hygiene etc. ',12),
    (27,'Handheld dog shower','Comes with handheld dog shower sprayer head, hand shower arm diverter',12),
    (28,'Single and double tap','Single tap type and double tap type available, fit for most of standard taps. ',13),
    (29,'Pet washing','Can be used for pet washing, help you to take care of your cat or dog at ease and keep them clean.',13),
    (30,'Light weight','Light weight, soft and flexible, easy to install and convenient to use. ',13),
    (31,'Chrome finished','Chrome finish to create a bright, highly reflective, guaranteed not to tarnish or corrode Bathroom Sink faucet ',14),
    (32,'Ceramic disc','Ceramic disc cartridge for smooth and long lasting operation bathtub sink faucet' ,14),
    (33,'Single handle','Single handle easy control of hot and cold water, Single hole easy installation basin mixer tap ',15),
    (34,'Durable','Durable lead-free solid brass construction. waterfall widespread vintage style bathroom vessel sink mixer tap, tall body ',15),
    (35,'Chrome finished','This universal bath shower head is made of high grade ABS. Chrome finish',16),
    (36,'Ready made','Two Panels Per Package, Each panel measures 117 x 138cm Drop, Inner Diameter of the Each Ring Measures 4cm. ',17),
    (37,'Only hardware','Only Hardware is sold, the door is not included. ',18),
    (38,'Thermal curtains','These thermal blackout curtains are made of 100 percent polyester and are imported.',19),
    (39,'3 Year Guarante' ,'3 Year Guarantee',20),
    (40,'Telescoping rod','Telescoping double rod has a 3/4-inch diameter front rod and 5/8-inch diameter back rod, and is available in 3 sizes to accommodate most windows ',21),
    (41,'Easy setup','Your Twilight double curtain rod comes with everything you need to get set up quickly and doesn''t require a curtain rod bracket',21),
    (42,'Brushed steel','Brushed Stainless Steel Door Knob Handle Passage Entrance Privacy Thumb Lock',22),
    (43,'Woodgrain effect','Woodgrain effect',23),
    (44,'Primed finish-ready','Primed finish-ready to paint',23),
    (45,'Real wood','Natural real wood venetian blinds',24),
    (46,'Metal brackets','Metal brackets that can be top, side or face fixed ',24),
    (47,'9 plants size','Up to 9 plants can be grown at a time. Plants grow in water, not soil. Advanced hydroponics made simple, Enjoy plants all year round. Grow fresh herbs, vegetables, salad leaves, flowers and more in this smart indoor garden ',25),
    (48,'Wood material','Wood material',26),
    (49,'Galvanised steel','Durable galvanised steel',27),
    (50,'85L capacity','Capacity: 85 Litres / 120 Kgs',28),
    (51,'Tissue holder','Tissue holder',29),
    (52,'Stainless fork','Stainless Steel Weed Fork with 40-Inch Handle',30),
    (53,'22cm high','Stands approx. 22cm high',31),
    (54,'Tree pack','Christmas tree pack',31),
    (55,'6 feet tall','6 feet tall Christmas Tree in plain green with 1000 tips, pvc material is suitable for both outdoor and indoor using. ',32),
    (56,'Foldable base','Designed with a durable metal body to use season after season, plus a foldable base for easy assembly. ',32),
    (57,'Material','Green plastic',33),
    (58,'9 feet tall','9 feet tall Christmas tree',34),
    (59,'Natural pine','Our natural wood slices are made of natural pine wood with barks and clearly visible wood grain.',35),
    (60,'High-quality','Our wood slices were drying, slicing, and picking out high-quality wood chips',35),
    (61,'Dining table','A solid oak rectangular dining table in a durable oiled finish',36),
    (62,'Dimensions','Dimensions (D x W x H): 118 x 75 x 75 cm',36),
    (63,'Folding foot','Folding foot, Piezo ignition, wind shield ',37),
    (64,'Double ceramic coating','Double ceramic coating, aluminium cookware set ',38),
    (65,'Stylish machine','Stylish bean-to-cup espresso/cappuccino machine with professional 15-bar pump pressure',39),
    (66,'Ventilation mode','Recirculation inside your kitchen with the use of carbon filters.',40),
    (67,'Small commode','Upholstered commode chair is small, easier to move around the patient''s room, at home or in clinical setting.',41),
    (68,'Easy setup','Provided with detailed instructions, the cubes are easy to assemble; and can be installed on the wall seamlessly with the screws and cloaking metal plates ',42),
    (69,'Large bay size','1500mm High x 700mm Wide x 300mm Deep and capable of holding 180kg per shelf',43),
    (70,'Modern design','Wood-patterned closed doors and walls',44),
    (71,'High carbon steel blade','High carbon steel blade for use in hard-to-reach areas',45),
    (72,'Tylon blade coating','Tylon blade coating gives durability and wear resistance than lacquer',46),
    (73,'Vibration absorbing handle','Vibration absorbing handle',47),
    (74,'Forged black','Forged black painted head',48),
    (75,'Polished faces','Hardened and tempered with polished faces and hardwood shaft',48),
    (76,'Chrome vanadium steel','Manufactured from chrome vanadium steel',49),
    (77,'Hardened and tempered','Carbon steel hardened and tempered',50)

DROP TABLE IF EXISTS Tags

CREATE TABLE Tags
(
    Id int NOT NULL,
    Value nvarchar(255) NULL,
    CONSTRAINT PK_Tags PRIMARY KEY(Id)
)

INSERT INTO Tags
VALUES
    (1, 'RechargeableScrewdriver'),
    (2, 'Multitool'),
    (3, 'HardHat')

DROP TABLE IF EXISTS Types

CREATE TABLE Types
(
    Id int NOT NULL,
    Code nvarchar(255) NULL,
    Name nvarchar(255) NULL,
    CONSTRAINT PK_Types PRIMARY KEY(Id)
)

INSERT INTO Types
VALUES
    (1, 'homeappliances' , 'Home Appliances'),
    (2, 'sink' , 'Sink'),
    (3, 'home' , 'Home'),
    (4, 'gardening' , 'Gardening'),
    (5, 'decor' , 'Decor'),
    (6, 'kitchen' , 'Kitchen Accessories'),
    (7, 'diytools' , 'DIY tools')

DROP TABLE IF EXISTS Products

CREATE TABLE Products
(
    Id int NOT NULL,
    Name nvarchar(255) NULL,
    Price decimal(9, 2) NULL,
    ImageName nvarchar(255) NULL,
    BrandId int NULL,
    TypeId int NULL,
    TagId int NULL,
    CONSTRAINT PK_Products PRIMARY KEY(Id)
)

INSERT INTO Products (Id,Name,Price,ImageName,BrandId,TypeId,TagId)
VALUES
    (1,'Microwave 0.9 Cu. Ft. 900 W',100,'10446729.jpg',1,1,NULL),
    (2,'Refrigerator 1.7 cu. ft. 110 watts',200,'24640268.jpg',3,1,NULL),
    (3,'Oven 900 W',300,'26881473.jpg',4,1,NULL),
    (4,'Washing machine 1200rpm',400,'31000074.jpg',2,1,NULL),
    (5,'Washing machine 900rpm',300,'31285507.jpg',1,1,NULL),
    (6,'Kitchen stoves' ,1400,'33641114.jpg',2,1,NULL),
    (7,'Refrigerator ft. 90 watts',400,'45808024.jpg',3,1,NULL),
    (8,'One Handle Stainless Steel Pull Out Kitchen Faucet',20,'47090355.jpg',3,1,NULL),
    (9,'Bathing System Classic 18 in. H x 60 in. W x 32.5',200,'12330912.jpg',1,2,NULL),
    (10,'Showerhead 1.75 gpm',40,'12866014.jpg',1,2,NULL),
    (11,'Toilet 1.28 gal.',180,'20155731.jpg',1,2,NULL),
    (12,'Black Bathing System Classic 18 in. H x 60 in. W x 32.5',250,'24547395.jpg',2,2,NULL),
    (13,'Bathroom Sink Faucet Waterfall',175,'25200686.jpg',2,2,NULL),
    (14,'Bathroom Sink Faucet',99,'40193368.jpg',2,2,NULL),
    (15,'Bathroom Sink Faucet Classic',100,'40887643.jpg',3,2,NULL),
    (16,'Showerhead 1.20 gpm',125,'46028385.jpg',3,2,NULL),
    (17,'Blend Solid White Sheer Curtains',110,'13778772.jpg',3,3,NULL),
    (18,'Door Hardware Kit Single Door',120,'17031875.jpg',4,3,NULL),
    (19,'White Sheer Curtains',105,'27367695.jpg',4,3,NULL),
    (20,'White Window',120,'34744564.jpg',4,3,NULL),
    (21,'Curtain Rod 48 in',25,'35268457.jpg',4,3,NULL),
    (22,'Steel Passage Door Knob',10,'39689828.jpg',1,3,NULL),
    (23,'White Door',123,'40505435.jpg',1,3,NULL),
    (24,'White Window Wood',230,'46655256.jpg',1,3,NULL),
    (25,'Indoor Kit Gardering',70,'9470575.jpg',3,4,NULL),
    (26,'Craftsman 100 ft. L x 5/8 in.',100,'12598356.jpg',3,4,NULL),
    (27,'Metal Watering Can',20,'12902526.jpg',3,4,NULL),
    (28,'Steel Contractor Wheelbarrow',100,'13894399.jpg',3,4,NULL),
    (29,'Craftsman 21 in. W 140',200,'15365639.jpg',3,4,NULL),
    (30,'Gardering',10,'29201547.jpg',2,4,NULL),
    (31,'Celebrations C9',10,'16658158.jpg',2,5,NULL),
    (32,'Artificial Tree',250,'23073793.jpg',2,5,NULL),
    (33,'Celebrations C8',5,'23536846.jpg',2,5,NULL),
    (34,'Artificial Tree Big',300,'23980448.jpg',2,5,NULL),
    (35,'Wood Pack',30,'31434677.jpg',1,5,NULL),
    (36,'Wood Table',395,'19806834.jpg',1,6,NULL),
    (37,'Kitchen Stoves',85,'27227580.jpg',1,6,NULL),
    (38,'Kit Metal Casseroles',125,'43229847.jpg',4,6,NULL),
    (39,'Coffee Maker Red',200,'52076809.jpg',4,6,NULL),
    (40,'Extractor Steal',135,'102013777.jpg',4,6,NULL),
    (41,'Wooden Commode',50,'21610747.jpg',1,7,NULL),
    (42,'Metal Shelving',90,'39696958.jpg',1,7,NULL),
    (43,'Big Metal Shelving',99,'49460165.jpg',2,7,NULL),
    (44,'Wooden Wardrobe',120,'51716553.jpg',2,7,NULL),
    (45,'Wooden Saw',145,'11143240.jpg',3,7,NULL),
    (46,'Measuring Tape',123,'13168288.jpg',3,7,NULL),
    (47,'Multi Function Drill',159,'14805480.jpg',2,7,NULL),
    (48,'Hammer',100,'19682904.jpg',2,7,NULL),
    (49,'Screwdriver',110,'51109515.jpg',1,7,NULL),
    (50,'Pliers',105,'85167541.jpg',1,7,NULL),
    (51,'Red multi-tool plier',50,'34312289.jpg',1,7,2),
    (52,'Blue multi-tool plier',50,'19595793.jpg',1,7,2),
    (53,'Stainless multi-tool plier',90,'35414723.jpg',1,7,2),
    (54,'Yellow Rechargeable screwdriver',250,'8704649.jpg',2,7,1),
    (55,'Red Rechargeable screwdriver',250,'6910004.jpg',1,7,1),
    (56,'Rechargeable screwdriver with extra battery',312,'63581524.jpg',2,7,1),
    (57,'Yellow hard hat with tool bag pack',46,'59890052.jpg',3,7,3),
    (58,'Single red garden gnome',56,'6112251.jpg',2,4,NULL),
    (59,'Two red garden gnomes',92,'10999322.jpg',2,4,NULL),
    (60,'One sat gnome',34,'24639790.jpg',2,4,NULL),
    (61,'One sat on shoe gnome',54,'24639792.jpg',2,4,NULL),
    (62,'One barrow gnome',29,'34369812.jpg',2,4,NULL),
    (63,'One glasses gnome',54,'34369851.jpg',2,4,NULL),
    (64,'One smiling gnome',43,'38786528.jpg',2,4,NULL),
    (65,'Two singing gnomes',65,'44333595.jpg',2,4,NULL),
    (66,'Two sleeping gnomes',32,'76911883.jpg',2,4,NULL),
    (67,'Seven-pack gnomes',250,'91797131.jpg',2,4,NULL),
    (68,'One afraid gnome',39,'106662449.jpg',2,4,NULL),
    (69,'One welcome gnome',28,'106906828.jpg',2,4,NULL),
    (70,'Two smiling gnomes',76,'106906834.jpg',2,4,NULL)