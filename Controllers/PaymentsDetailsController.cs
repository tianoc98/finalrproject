﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject1.Data;
using FinalProject1.Models;
using FinalProject1.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace FinalProject1.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsDetailsController : ControllerBase
    {
        private readonly PaymentContext _context;

        public PaymentsDetailsController(PaymentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> getItems()
        {
            var items = await _context.CardInfo.ToListAsync();
            return Ok(items);
        }
        [HttpPost]
        public async Task<IActionResult> CreateItem(PaymentDetails data)
        {
            if (ModelState.IsValid)
            {
                await _context.CardInfo.AddAsync(data);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetItem", new { data.Id }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getItem(int id)
        {
            var items = await _context.CardInfo.FirstOrDefaultAsync(x => x.Id == id);
            if (items == null)
            {
                return NotFound();
            }
            return Ok(items);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var items = await _context.CardInfo.FirstOrDefaultAsync(x => x.Id == id);
            if (items == null)
            {
                return new JsonResult("Item Dengan Id = " + id + " Tidak di temukan") { StatusCode = 500 };
            }
            _context.CardInfo.Remove(items);
            var msg = "Item Dengan Id = " + id + "Berhasil Di Hapus";
            await _context.SaveChangesAsync();

            return Ok(new Response()
            {
                Name = "Deleting Item",
                Success = true,
                Message = msg
            });
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateItem(PaymentDetails data, int id)
        {
            var items = await _context.CardInfo.FirstOrDefaultAsync(x => x.Id == id);
            if (items == null)
            {
                return new JsonResult("Item Dengan Id = "+id+" Tidak di temukan") { StatusCode = 500 };
            }
            _context.Entry(items).CurrentValues.SetValues(data);
            await _context.SaveChangesAsync();
            var msg = "Item Dengan Id = " + id + "Berhasil Di Update";
            return Ok(new Response()
            {
                Name = "Updating Data",
                Success = true,
                Message = msg
            });

        }
    }
}
