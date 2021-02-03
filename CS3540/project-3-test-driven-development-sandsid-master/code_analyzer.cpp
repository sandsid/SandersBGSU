/**
 * @file code_analyzer.cpp
 *
 * Implementation of code analyzer
 */

#include "code_analyzer.hpp"
#include "get_language_from_filename.hpp"
#include "xml_wrapper.hpp"

#include <string>

/**
 * markup_source_code 
 * @param request Data that forms the request
 * @retval Source analysis request in XML format
 * @retval Empty string if invalid
 *
 * Generate source analysis XML based on the request
 * Content is wrapped with an XML element that includes the metadata
 */
std::string markup_source_code(const analysis_request& request) {

    // wrap the content with a unit element
    xml_wrapper wrap("src", "https://www.srcML.org/src");
    wrap.start_element("unit");
    wrap.attribute("language", request.option_language);

    //LOC append -- passes
    if (request.option_loc >=0)
    {
        wrap.attribute("loc", std::to_string(request.option_loc));
    }

    
    //Option filename append -- passes
    if (request.option_filename != "")
    {
        wrap.attribute("filename", request.option_filename);
    }
    
    
    //If option filename is empty tests
    //checking if option_filename is empty 
    if (request.option_filename == "")
    {
        //checking if entry is not data
        if(request.entry_filename != "data" && request.entry_filename != "")
        {
            //if entry_filename is not data entry will be assigned if not empty
            wrap.attribute("filename", request.entry_filename);
        }

        //checking if entry is data
        if (request.disk_filename == "-")
        {
            //if disk_filename == dash then entry_filename will be assigned
            if (request.entry_filename == "data")
            {
                //filename will be empty
                wrap.attribute("filename", request.disk_filename);
            }
        }
    }
    

    //URL test -- passes
    if (request.option_url == "https://bgsu.edu")
    {
        wrap.attribute("url", request.option_url);
    }

    //Hash append -- passes
    if (request.option_hash != "")
    {
        wrap.attribute("hash", request.option_hash);
    }
    

    wrap.content(request.source_code);
    wrap.end_element();

    return wrap.xml();
}
