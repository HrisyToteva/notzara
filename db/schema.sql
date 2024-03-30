Create TABLE "Item"
(
    "Id" UUID PRIMARY KEY,
    "Name" text not null,
    "Type" integer not null,
    "Price" real not null,
    "Description" text null
   
);



Create TABLE "Basket"
(
    "Id" UUID PRIMARY KEY,
    "Email" text not null

);

Create TABLE "Basket_Items"
(
    "Id" UUID primary key,
    "BasketId" UUID not null,
    "ItemId" UUID not null

--     constraint "Basket_FK" foreign key ("BasketId") references "Basket" ("Id") on delete cascade,
--     constraint "Item_FK" foreign key ("ItemId") references "Item" ("Id") on delete cascade
);


insert into "Item" ("Id", "Name", "Price", "Description", "Type")
values ('0937862A-3583-4038-AEAB-59BB68272A22', 'nike t-shirt', 1.37, '', 1);
insert into "Item" ("Id", "Name", "Price", "Description", "Type")
values ('EB85DCE5-C136-4572-8657-C9334DB522BC', 'dark green sweater with bulgarian text', 1.37, '', 1);
insert into "Item" ("Id", "Name", "Price", "Description", "Type")
values ('D491590E-EFE2-4D46-8A14-EFD6CC15639E', 'cool shoes', 1.37, '', 2);

insert into "Basket" ("Id", "Email")
values ('944ED6CC-B7E2-4DF3-BD2D-3C3EFAF2848F', 'hritote@seq.tf');
insert into "Basket" ("Id", "Email")
values ('4933CB22-0987-4F0C-A156-BE4038590365', 'emcla@seq.tf');

insert into "Basket_Items" ( "Id", "BasketId", "ItemId")
values ('819F7767-50F0-436C-A3F3-EF4FF51D2A31', '944ED6CC-B7E2-4DF3-BD2D-3C3EFAF2848F',
        'EB85DCE5-C136-4572-8657-C9334DB522BC');
insert into "Basket_Items" ( "Id", "BasketId", "ItemId")
values ( 'DE874FB0-ED3D-4E23-B474-DAC7C14A4F4C', '944ED6CC-B7E2-4DF3-BD2D-3C3EFAF2848F',
        'D491590E-EFE2-4D46-8A14-EFD6CC15639E');

insert into "Basket_Items" ( "Id", "BasketId", "ItemId")
values ( '3F5F051F-7290-4AAB-940C-9EED29392190', '4933CB22-0987-4F0C-A156-BE4038590365',
        'D491590E-EFE2-4D46-8A14-EFD6CC15639E');

