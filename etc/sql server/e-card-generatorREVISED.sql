drop table cards;
drop table card_templates;
drop table months;
drop table holidays;
drop table holiday_months;

create table card_templates
(
	id			int				identity(1,1),
	name		varchar(255)	not null,
	imageName	varchar(255) 	not null,
	fontColor	varchar(100)	not null,
			
	constraint pk_card_templates primary key (id)
);


create table cards
(
	id			int				identity(1,1),
	template_id	int				not null,
	to_email	varchar(100)	not null,
	to_name		varchar(100)	not null,
	message		varchar(100)	not null,
	from_name	varchar(100)	not null,
	from_email	varchar(100)	not null,


	constraint pk_cards primary key(id),
	constraint fk_cards_card_templates foreign key (template_id) references card_templates(id)
);


create table months
(
	id int identity(1,1),
	name varchar(12) not null, 
	number_of_days int not null,
	
	constraint pk_months primary key(id)	
);


create table holidays
(
	id				int			identity(1,1),
	holiday_name	varchar(32)	not null,
	month_id		int			not null,
	day_of_month	int			not null,

	constraint pk_holidays primary key(id),
	constraint fk_holidays_months foreign key (month_id) references months(id)	
);

create table holiday_months
(
	month_id		int		not null,
	holiday_id		int		not null,

	constraint fk_holidays_months_months foreign key (month_id) references months(id),
	constraint fk_holidays_months_holidays foreign key (holiday_id) references holidays(id)
);

create table card_user
(
	users_id varchar(50) not null,


)

insert into card_templates values ('Blue Card', 'blue.jpg', '#ffffff');
insert into card_templates values ('Green Card', 'green.jpg', '#ffffff');
insert into card_templates values ('Grey Card', 'light-grey.jpg', '#000000');
insert into card_templates values ('Salmon Card', 'salmon.jpg', '#ffffff');

insert into cards values (1, 'john@xyz.com', 'John', 'Get well soon!', 'Jack', 'jack@abc.com');

insert into months values ('January', 31);
insert into months values ('February', 28);
insert into months values ('March', 31);
insert into months values ('April', 30);
insert into months values ('May', 31);
insert into months values ('June', 30);
insert into months values ('July', 31);
insert into months values ('August', 31);
insert into months values ('September', 30);
insert into months values ('October', 31);
insert into months values ('November', 30);
insert into months values ('December', 31);

insert into holidays values ('New Years Eve', 1, 1);
insert into holidays values ('Valentines Day', 2, 14);
insert into holidays values ('St. Patricks Day', 3, 17);
insert into holidays values ('April Fools Day', 4, 1);
insert into holidays values ('Memorial Day', 5, 29);
insert into holidays values ('D-Day', 6, 6);
insert into holidays values ('Independence Day', 7, 4);
insert into holidays values ('National Watermelon Day', 8, 3);
insert into holidays values ('Labor Day', 9, 24);
insert into holidays values ('Halloween', 10, 31);
insert into holidays values ('Thanksgiving', 11, 23);
insert into holidays values ('Christmas', 12, 25);




