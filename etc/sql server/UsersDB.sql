--drop table background;
--drop table fonts;
--drop table image_info;
--drop table users_cards;
--drop table cards;
--drop table users;


create table users
(
id int identity(1,1),
user_guid varchar(35) not null,
userName varchar(35) not null,
user_pw varchar(35) not null,

constraint pk_users primary key (id),
constraint uq_user_guid unique(user_guid)
);


create table cards
(
card_id int identity(1,1),
card_guid varchar(35) not null,
font_id int not null,
image_id int not null,
message_top varchar(50),
message_middle varchar(50),
message_bottom varchar(50),

constraint pk_cards primary key (card_id),
constraint uq_card_guid unique(card_guid)
);


create table users_cards
(
user_guid varchar(35) not null,
card_guid varchar(35) not null,
 
constraint fk_user_user_guid foreign key (user_guid) references users(user_guid),
constraint fk_card_card_guid foreign key (card_guid) references cards(card_guid),
constraint pk_users_cards primary key (card_guid, user_guid)
)


create table fonts
(
id int identity(1,1),
name varchar(30) not null,
font_guid varchar(35) not null,

constraint pk_fonts primary key (id),
constraint uq_font_guid unique(font_guid)
);
	

create table image_info
(
id int identity(1,1),
name varchar(24) not null,
image_guid varchar(35) not null,
image_path varchar(255) not null,

constraint image_info primary key(id),
constraint uq_unique unique (image_guid)
);


create table background
(
id int identity(1,1),
name varchar(50) not null,
color_code varchar(12) not null,

constraint pk_background primary key(id),
constraint uq_color_code unique (color_code)
);
