//Make some fresh tables using executescript()

//basic queries that need to be updated for CS language
/*cur.executescript('''


CREATE TABLE Account IF NOT EXISTS (
    id  INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
    username    TEXT UNIQUE,
    password  //hash and salt
    email TEXT UNIQUE,
    project_id INTEGER

);


CREATE TABLE Project IF NOT EXISTS (
    id  INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
    account_id  INTEGER,
    title   TEXT UNIQUE,
    description TEXT,
    subject TEXT,
    funding INTEGER,
    deadline DATE,
    picture TEXT,
    skillsRequired TEXT,
    %funding INTEGER
);

''') */
