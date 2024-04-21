using Snowflake;

print(SnowflakeGenerator.Info());

print(long.MaxValue);


print(SnowflakeId.Generate());
print(SnowflakeId.Generate());

await Task.Delay(1000);
print(SnowflakeId.Generate());
await Task.Delay(1000);
print(SnowflakeId.Generate());


/*
[2024.04.21:06:16.50.653] [12 ms]       50265103443689472
[2024.04.21:06:16.50.653] [0 ms]        50265103443755008
[2024.04.21:06:16.51.665] [1011 ms]     50265103510011904
[2024.04.21:06:16.52.678] [1013 ms]     50265103576465408



*/