const { argv } = require('node:process');

if (argv.length <= 2)
{
    console.log();
}

if (argv.length == 3)
{
    console.log(argv[2]);
}

