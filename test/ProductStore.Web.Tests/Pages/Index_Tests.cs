﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ProductStore.Pages;

public class Index_Tests : ProductStoreWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
