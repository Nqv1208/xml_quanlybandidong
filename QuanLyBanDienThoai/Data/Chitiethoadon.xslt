<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" encoding="UTF-8" indent="yes"/>
    
    <xsl:template match="/">
        <html lang="vi">
            <head>
                <meta charset="utf-8"/>
                <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
                <title>Chi Tiết Hóa Đơn</title>
                <style>
                    * { 
                        margin: 0; 
                        padding: 0; 
                        box-sizing: border-box; 
                    }
                    
                    body { 
                        font-family: 'Inter', 'Segoe UI', -apple-system, BlinkMacSystemFont, sans-serif;
                        background: #f8f9fa;
                        padding: 40px 20px;
                        min-height: 100vh;
                        color: #1a1a1a;
                    }
                    
                    .container { 
                        max-width: 1200px;
                        margin: 0 auto;
                        background: white;
                        border-radius: 12px;
                        box-shadow: 0 2px 8px rgba(0,0,0,0.06);
                        overflow: hidden;
                    }
                    
                    .header { 
                        background: linear-gradient(135deg, #dc2626 0%, #ef4444 100%);
                        color: white;
                        padding: 40px;
                    }
                    
                    .header h1 { 
                        font-size: 28px;
                        font-weight: 700;
                        margin-bottom: 20px;
                        letter-spacing: -0.5px;
                    }
                    
                    .info-grid {
                        display: grid;
                        grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
                        gap: 20px;
                        margin-top: 20px;
                    }
                    
                    .info-item {
                        background: rgba(255, 255, 255, 0.15);
                        padding: 15px;
                        border-radius: 8px;
                        backdrop-filter: blur(10px);
                    }
                    
                    .info-label {
                        font-size: 12px;
                        opacity: 0.9;
                        margin-bottom: 5px;
                        text-transform: uppercase;
                        letter-spacing: 0.5px;
                    }
                    
                    .info-value {
                        font-size: 16px;
                        font-weight: 600;
                    }
                    
                    .content { 
                        padding: 40px;
                    }
                    
                    .section-title {
                        font-size: 20px;
                        font-weight: 600;
                        color: #1a1a1a;
                        margin-bottom: 20px;
                        padding-bottom: 10px;
                        border-bottom: 2px solid #e5e7eb;
                    }
                    
                    .table-wrapper { 
                        overflow-x: auto;
                        border-radius: 10px;
                        border: 1px solid #e5e7eb;
                    }
                    
                    table { 
                        width: 100%;
                        border-collapse: collapse;
                        background: white;
                    }
                    
                    thead {
                        background: #f9fafb;
                        border-bottom: 2px solid #e5e7eb;
                    }
                    
                    th { 
                        color: #374151;
                        font-weight: 600;
                        padding: 16px 20px;
                        text-align: left;
                        font-size: 13px;
                        text-transform: uppercase;
                        letter-spacing: 0.5px;
                    }
                    
                    tbody tr { 
                        transition: background-color 0.15s ease;
                        border-bottom: 1px solid #f3f4f6;
                    }
                    
                    tbody tr:hover { 
                        background-color: #f9fafb;
                    }
                    
                    td { 
                        padding: 16px 20px;
                        color: #1f2937;
                        font-size: 14px;
                        vertical-align: middle;
                    }
                    
                    .text-center {
                        text-align: center;
                    }
                    
                    .text-right {
                        text-align: right;
                    }
                    
                    .sp-code {
                        font-family: 'Courier New', monospace;
                        color: #2563eb;
                        font-weight: 500;
                        font-size: 13px;
                    }
                    
                    .price-cell {
                        font-weight: 600;
                        color: #dc2626;
                        font-family: 'Courier New', monospace;
                    }
                    
                    .total-row {
                        background: #fef2f2;
                        font-weight: 700;
                        border-top: 2px solid #ef4444;
                    }
                    
                    .total-label {
                        text-align: right;
                        padding-right: 20px;
                        color: #991b1b;
                        font-size: 16px;
                    }
                    
                    .total-value {
                        color: #dc2626;
                        font-size: 18px;
                    }
                    
                    .footer { 
                        background: #f9fafb;
                        padding: 24px 40px;
                        text-align: center;
                        color: #6b7280;
                        font-size: 13px;
                        border-top: 1px solid #e5e7eb;
                    }
                    
                    @media print { 
                        body { 
                            background: white;
                            padding: 0;
                        }
                        
                        .container { 
                            box-shadow: none;
                            border-radius: 0;
                        }
                    }
                    
                    @media (max-width: 768px) { 
                        body {
                            padding: 20px 10px;
                        }
                        
                        .header, .content { 
                            padding: 24px 20px;
                        }
                        
                        .info-grid {
                            grid-template-columns: 1fr;
                        }
                        
                        th, td { 
                            padding: 12px 16px;
                            font-size: 13px;
                        }
                    }
                </style>
            </head>
            <body>
                <div class="container">
                    <div class="header">
                        <h1>📑 Chi Tiết Hóa Đơn</h1>
                        <div class="info-grid">
                            <div class="info-item">
                                <div class="info-label">Mã Hóa Đơn</div>
                                <div class="info-value"><xsl:value-of select="//HoaDonInfo/MaHD"/></div>
                            </div>
                            <div class="info-item">
                                <div class="info-label">Khách Hàng</div>
                                <div class="info-value"><xsl:value-of select="//HoaDonInfo/TenKH"/></div>
                            </div>
                            <div class="info-item">
                                <div class="info-label">Nhân Viên</div>
                                <div class="info-value"><xsl:value-of select="//HoaDonInfo/TenNV"/></div>
                            </div>
                            <div class="info-item">
                                <div class="info-label">Ngày Lập</div>
                                <div class="info-value">
                                    <xsl:variable name="dateStr" select="normalize-space(//HoaDonInfo/NgayLap)"/>
                                    <xsl:choose>
                                        <!-- Format ISO với T: 2024-02-25T10:30:00 hoặc 2024-02-25T10:30:00.000 -->
                                        <xsl:when test="contains($dateStr, 'T')">
                                            <xsl:variable name="datePart" select="substring-before($dateStr, 'T')"/>
                                            <xsl:variable name="timePart" select="substring-after($dateStr, 'T')"/>
                                            <xsl:variable name="year" select="substring($datePart, 1, 4)"/>
                                            <xsl:variable name="month" select="substring($datePart, 6, 2)"/>
                                            <xsl:variable name="day" select="substring($datePart, 9, 2)"/>
                                            <xsl:variable name="hour" select="substring($timePart, 1, 2)"/>
                                            <xsl:variable name="minute" select="substring($timePart, 4, 2)"/>
                                            <xsl:value-of select="concat($day, '/', $month, '/', $year, ' ', $hour, ':', $minute)"/>
                                        </xsl:when>
                                        <!-- Format ISO không có T: 2024-02-25 10:30:00 -->
                                        <xsl:when test="string-length($dateStr) >= 19 and contains($dateStr, '-') and contains($dateStr, ':')">
                                            <xsl:variable name="spacePos" select="string-length(substring-before($dateStr, ' ')) + 1"/>
                                            <xsl:variable name="datePart" select="substring($dateStr, 1, $spacePos - 1)"/>
                                            <xsl:variable name="timePart" select="substring($dateStr, $spacePos + 1, 8)"/>
                                            <xsl:variable name="year" select="substring($datePart, 1, 4)"/>
                                            <xsl:variable name="month" select="substring($datePart, 6, 2)"/>
                                            <xsl:variable name="day" select="substring($datePart, 9, 2)"/>
                                            <xsl:value-of select="concat($day, '/', $month, '/', $year, ' ', substring($timePart, 1, 5))"/>
                                        </xsl:when>
                                        <!-- Format chỉ có ngày: 2024-02-25 -->
                                        <xsl:when test="string-length($dateStr) = 10 and contains($dateStr, '-')">
                                            <xsl:variable name="year" select="substring($dateStr, 1, 4)"/>
                                            <xsl:variable name="month" select="substring($dateStr, 6, 2)"/>
                                            <xsl:variable name="day" select="substring($dateStr, 9, 2)"/>
                                            <xsl:value-of select="concat($day, '/', $month, '/', $year)"/>
                                        </xsl:when>
                                        <!-- Format đã là dd/MM/yyyy -->
                                        <xsl:when test="contains($dateStr, '/') and string-length($dateStr) >= 8">
                                            <xsl:value-of select="$dateStr"/>
                                        </xsl:when>
                                        <!-- Trường hợp khác, hiển thị nguyên bản -->
                                        <xsl:otherwise>
                                            <xsl:value-of select="//HoaDonInfo/NgayLap"/>
                                        </xsl:otherwise>
                                    </xsl:choose>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <div class="content">
                        <div class="section-title">Danh Sách Sản Phẩm</div>
                        <div class="table-wrapper">
                            <table>
                                <thead>
                                    <tr>
                                        <th>Mã CT</th>
                                        <th>Mã SP</th>
                                        <th>Tên Sản Phẩm</th>
                                        <th class="text-center">Số Lượng</th>
                                        <th class="text-right">Đơn Giá</th>
                                        <th class="text-right">Thành Tiền</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <xsl:for-each select="//ChiTietHoaDon">
                                        <tr>
                                            <td><xsl:value-of select="MaCTHD"/></td>
                                            <td>
                                                <span class="sp-code">
                                                    <xsl:value-of select="MaSP"/>
                                                </span>
                                            </td>
                                            <td><xsl:value-of select="TenSP"/></td>
                                            <td class="text-center"><xsl:value-of select="SoLuong"/></td>
                                            <td class="text-right price-cell">
                                                <xsl:value-of select="format-number(DonGia, '#,##0')"/>
                                                <xsl:text> đ</xsl:text>
                                            </td>
                                            <td class="text-right price-cell">
                                                <xsl:value-of select="format-number(ThanhTien, '#,##0')"/>
                                                <xsl:text> đ</xsl:text>
                                            </td>
                                        </tr>
                                    </xsl:for-each>
                                    <tr class="total-row">
                                        <td colspan="5" class="total-label">TỔNG TIỀN:</td>
                                        <td class="text-right total-value">
                                            <xsl:value-of select="format-number(sum(//ChiTietHoaDon/ThanhTien), '#,##0')"/>
                                            <xsl:text> đ</xsl:text>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    
                    <div class="footer">
                        <p>
                            Hệ thống quản lý bán điện thoại | <strong>Báo cáo được tạo tự động</strong> | © 2024
                        </p>
                    </div>
                </div>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>