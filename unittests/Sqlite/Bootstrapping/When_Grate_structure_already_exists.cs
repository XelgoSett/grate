﻿using Sqlite.TestInfrastructure;
using TestCommon.TestInfrastructure;

namespace Sqlite.Bootstrapping;

[Collection(nameof(SqliteTestDatabase))]
// ReSharper disable once InconsistentNaming
// ReSharper disable once UnusedType.Global
public class When_Grate_structure_already_exists(SqliteGrateTestContext context, ITestOutputHelper testOutput)
    : TestCommon.Generic.Bootstrapping.When_Grate_structure_already_exists(context, testOutput);

