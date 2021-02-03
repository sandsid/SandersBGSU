/**
 * @file test_code_analysis.cpp
 *
 *  Test program for analysis requests
 */

#include "code_analyzer.hpp"

#include <string>
#include <cassert>

/*
 * main
 * @retval 0 if successfully run, nonzero otherwise
 *
 * Tests markup_source_code() using TDD approach
 * Use simple testing each in a separate {} as use below or Boost.Test
 */
int main() {

    // option language
    {
        analysis_request request;
        request.source_code = R"(
if (a < b) a = b;
)";
        request.disk_filename  = "";
        request.entry_filename  = "";
        request.option_filename = "";
        request.source_url = "";
        request.option_url = "";
        request.option_language = "C++";
        request.default_language = "";
        request.option_loc = -1;
        

        assert(markup_source_code(request) ==
            R"(<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<src:unit xmlns:src="https://www.srcML.org/src" language="C++">
if (a &lt; b) a = b;
</src:unit>
)");
    }

    //LOC Test
    {
        analysis_request request;
        request.source_code = R"(
if (a < b) a = b;
)";
        request.disk_filename = "";
        request.entry_filename  = "";
        request.option_filename = "";
        request.source_url = "";
        request.option_url = "";
        request.option_language = "C++";
        request.default_language = "";
        request.option_loc = 5;

        assert(markup_source_code(request) ==
            R"(<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<src:unit xmlns:src="https://www.srcML.org/src" language="C++" loc="5">
if (a &lt; b) a = b;
</src:unit>
)");
    }

   
    //option filename
    {
        analysis_request request;
        request.source_code = R"(
if (a < b) a = b;
)";
        request.disk_filename = "-";
        request.entry_filename  = "data";
        request.option_filename = "bgsu.cpp";
        request.source_url = "";
        request.option_url = "";
        request.option_language = "C++";
        request.default_language = "";
        request.option_loc = 5;
        request.option_hash = "";

        assert(markup_source_code(request) ==
            R"(<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<src:unit xmlns:src="https://www.srcML.org/src" language="C++" loc="5" filename="bgsu.cpp">
if (a &lt; b) a = b;
</src:unit>
)");
    }
    
    /*
    //entry filename
    {
        analysis_request request;
        request.source_code = R"(
if (a < b) a = b;
)";
        request.disk_filename = "-";
        request.entry_filename  = "bgsu.edu";
        request.option_filename = "";
        request.source_url = "";
        request.option_url = "";
        request.option_language = "C++";
        request.default_language = "";
        request.option_loc = 5;
        request.option_hash = "";

        assert(markup_source_code(request) ==
            R"(<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<src:unit xmlns:src="https://www.srcML.org/src" language="C++" loc="5" filename="bgsu.cpp">
if (a &lt; b) a = b;
</src:unit>
)");
    }
    */


    //URL 
    {
        analysis_request request;
        request.source_code = R"(
if (a < b) a = b;
)";
        request.disk_filename = "-";
        request.entry_filename  = "data";
        request.option_filename = "bgsu.cpp";
        request.source_url = "";
        request.option_url = "https://bgsu.edu";
        request.option_language = "C++";
        request.default_language = "";
        request.option_loc = 5;
        request.option_hash = "";

        assert(markup_source_code(request) ==
            R"(<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<src:unit xmlns:src="https://www.srcML.org/src" language="C++" loc="5" filename="bgsu.cpp" url="https://bgsu.edu">
if (a &lt; b) a = b;
</src:unit>
)");
    }

    //Hash test 
    {
        analysis_request request;
        request.source_code = R"(
if (a < b) a = b;
)";
        request.disk_filename = "-";
        request.entry_filename = "data";
        request.option_filename = "bgsu.cpp";
        request.source_url = "";
        request.option_url = "https://bgsu.edu";
        request.option_language = "C++";
        request.default_language = "";
        request.option_loc = 5;
        request.option_hash = "39dcad4f59855aa76420aa3d69af3d7ba30a91bb";

        assert(markup_source_code(request) ==
            R"(<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<src:unit xmlns:src="https://www.srcML.org/src" language="C++" loc="5" filename="bgsu.cpp" url="https://bgsu.edu" hash="39dcad4f59855aa76420aa3d69af3d7ba30a91bb">
if (a &lt; b) a = b;
</src:unit>
)");
    }

/*
    //for next test
    {
        analysis_request request;
        request.source_code = R"(
if (a < b) a = b;
)";
        request.disk_filename = "-";
        request.entry_filename = "data";
        request.option_filename = "bgsu.cpp";
        request.source_url = "";
        request.option_url = "https://bgsu.edu";
        request.option_language = "C++";
        request.default_language = "";
        request.option_loc = 5;
        request.option_hash = "39dcad4f59855aa76420aa3d69af3d7ba30a91bb";

        assert(markup_source_code(request) ==
            R"(<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<src:unit xmlns:src="https://www.srcML.org/src" language="C++" loc="5" filename="bgsu.cpp" url="https://bgsu.edu" hash="39dcad4f59855aa76420aa3d69af3d7ba30a91bb">
if (a &lt; b) a = b;
</src:unit>
)");
    }
*/

    return 0;
}








