﻿using MariaDB.TestInfrastructure;
using TestCommon.Generic;
using TestCommon.TestInfrastructure;

namespace MariaDB;

[Collection(nameof(MariaDbTestContainer))]
public class Database : GenericDatabase, IClassFixture<SimpleService>
{
    protected override IGrateTestContext Context { get; }

    protected ITestOutputHelper TestOutput { get; }

    public Database(MariaDbTestContainer testContainer, SimpleService simpleService, ITestOutputHelper testOutput)
    {
        Context = new MariaDbGrateTestContext(simpleService.ServiceProvider, testContainer);
        TestOutput = testOutput;
    }
}
