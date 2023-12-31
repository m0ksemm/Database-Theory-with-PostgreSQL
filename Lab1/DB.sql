PGDMP     *    4            	    {        !   Inventory of warehouse accounting    15.4    15.4     5           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            6           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            7           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            8           1262    16398 !   Inventory of warehouse accounting    DATABASE     �   CREATE DATABASE "Inventory of warehouse accounting" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
 3   DROP DATABASE "Inventory of warehouse accounting";
                postgres    false            '          0    16402    Category 
   TABLE DATA           2   COPY public."Category" ("Id", "Name") FROM stdin;
    public          postgres    false    216   �       )          0    16410    City 
   TABLE DATA           .   COPY public."City" ("Id", "Name") FROM stdin;
    public          postgres    false    218   �       1          0    16452    Manufacturer 
   TABLE DATA           6   COPY public."Manufacturer" ("Id", "Name") FROM stdin;
    public          postgres    false    226          0          0    16436    Product 
   TABLE DATA           �   COPY public."Product" ("Id", "Name", "Vendor_code", "Serial_number", "Delivery_date", "Quantity", "Manufacturer_Id", "Category_Id") FROM stdin;
    public          postgres    false    225   h       ,          0    16425 	   Warehouse 
   TABLE DATA           X   COPY public."Warehouse" ("Id", "Name", "City_Id", "Square_area", "Address") FROM stdin;
    public          postgres    false    221   �       2          0    16471    Warehouses_Products 
   TABLE DATA           S   COPY public."Warehouses_Products" ("Id", "Warehouse_Id", "Product_Id") FROM stdin;
    public          postgres    false    227          @           0    0    Category_Id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Category_Id_seq"', 4, true);
          public          postgres    false    215            A           0    0    City_Id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public."City_Id_seq"', 3, true);
          public          postgres    false    217            B           0    0    Product_Category_Id_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."Product_Category_Id_seq"', 1, false);
          public          postgres    false    224            C           0    0    Product_Id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Product_Id_seq"', 15, true);
          public          postgres    false    222            D           0    0    Product_Manufacturer_Id_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."Product_Manufacturer_Id_seq"', 1, false);
          public          postgres    false    223            E           0    0    Warehouse_City_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."Warehouse_City_seq"', 1, false);
          public          postgres    false    220            F           0    0    Warehouse_Id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public."Warehouse_Id_seq"', 6, true);
          public          postgres    false    219            '   2   x�3�t+-��,)-J�2�t,(��L�KN-�2�tN��Q(����b���� ?�i      )   "   x�3����,�2�t��,(��2��)�c���� o\(      1   >   x�3��q�2�t�/��2�N�-.�K�2�t,(�I���2��L����2��w������� �[�      0   q  x�E��N�0Eד�����m[�(BD�X��J �h�R���Deɲd_�{���x:�/�ɯ��۴,p�c �'���5�����o�4v�ļ�l�S��"^$| ��|8�����屛�j:�fO�[m,��� /��"'��D �*���M+���oh�}>&,���F[SeU	�}f��!X��B@	��3!-B���3�z�ẇ~Є+M�ى���P��H=Z=.��}�t����sADXo5�u��b���(%YR�R��n8��g����э�ۧb�#x⥀ThN'Rh���yx���>ͦQ �7$EJ0����5+���o|1��8B�0�2{-+&J�ҟ�$K�WUU� �{z�      ,   �   x�Mλ
�@��z�)�B�ً&��(���f��A͆Y��gA��?��*:��'��Pq�gz���ġ��m-���3p���om�3��:p���*��Qe��P�Σ��/�7p�����u�⮄-�ZD� ��1E      2   ;   x����0���0\�4@wa�9H>�Og/Y�4�W�ͣTq7�ŋ='���(��⻀@y�     