using SudokuGenerator.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;
using System.Web.Http.Cors;

namespace SudokuGenerator.Controllers
{
    //to allow cross origin requests
    [EnableCors(origins: "*", headers: "*", methods: "*")] 
    public class SudokuController : ApiController
    {
        // GET sudoku/board
        [HttpGet]
        [Route("sudoku/board")]
        public HttpResponseMessage board()
        {
            try
            {
                int[] responseobj = new int[81];
                Sudoku objSudoku = new Sudoku();
                responseobj = objSudoku.GenerateSudokuBoard();

                //return array of 81 integers in response
                return Request.CreateResponse(HttpStatusCode.OK, responseobj);
            }
            catch (Exception ex)
            {
                var response = new Response { Message = ex.Message };
                return Request.CreateResponse(HttpStatusCode.BadRequest, response);
            }

        }
    }
}
