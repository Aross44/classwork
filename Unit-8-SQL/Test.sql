-- list all the Gamblers
select * from gambler;

-- list all the rows in the host table
select * from host;

-- show the name of each gambler and the casino name that hosts them 
--
-- gambler_name is in the gambler table 
-- casino_name is in the host table 
-- when you need data from more than one table you must find out what connects them 
-- the id of the gambler connects the gambler to the host table 
--
-- Because the id of the gambler has the same name in both tables 
-- We qualify which table we want to take the id from 
--
--a qualified name: table-name.colum-name
--
-- whenever you need data from more than one table - its a JOIN (inner join)
--

--
--Classic syntax Join
--
--
-- if you forget the where clause on the jooin you get a cartesian product
-- (all rows from table with all rows from the other - NOT a JOIN)
--No error would be generated 
--
select gambler_name, casino_name
	from gambler, host 	-- table(s) that have the data you need 
	where gambler.id = host.id 				-- rows wanted in the result - rows that match between gambler and host tables 
	;
	--
	--Modern Syntax
	--
	-- You cannot forget the join condition - ON phrase as it will generate an error 
	--
	select gambler_name,casino_name
	from gambler		-- code one table on the from 
	inner join			-- type of join (instead of a ,)
		host			-- code the other table
	  on gambler.id = host.id -- join/match condition 
;
	
	select gambler_name,casino_name
	  from gambler inner join host
	  on gambler.id = host.id
	  ;