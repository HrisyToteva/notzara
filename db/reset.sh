#!/bin/sh

export PGPASSWORD=p

psql "host=127.0.0.1 port=5432 user=postgres" -c 'DROP DATABASE "notzara"'

psql "host=127.0.0.1 port=5432 user=postgres" -c 'CREATE DATABASE "notzara"'
psql "host=127.0.0.1 port=5432 user=postgres dbname=notzara" -f schema.sql