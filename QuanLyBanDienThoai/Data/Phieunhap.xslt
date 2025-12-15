<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" encoding="UTF-8" indent="yes"/>
    
    <xsl:template match="/">
        <html lang="vi">
            <head>
                <meta charset="utf-8"/>
                <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
                <title>Danh Sách Phiếu Nhập</title>
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
                        max-width: 1400px;
                        margin: 0 auto;
                        background: white;
                        border-radius: 12px;
                        box-shadow: 0 2px 8px rgba(0,0,0,0.06);
                        overflow: hidden;
                    }
                    
                    .header { 
                        background: white;
                        padding: 40px;
                        border-bottom: 1px solid #e5e7eb;
                    }
                    
                    .header-content {
                        display: flex;
                        justify-content: space-between;
                        align-items: center;
                        flex-wrap: wrap;
                        gap: 20px;
                    }
                    
                    .header-left h1 { 
                        font-size: 28px;
                        font-weight: 700;
                        color: #1a1a1a;
                        margin-bottom: 8px;
                        letter-spacing: -0.5px;
                    }
                    
                    .header-left p { 
                        font-size: 14px;
                        color: #6b7280;
                        font-weight: 400;
                    }
                    
                    .header-right {
                        display: flex;
                        align-items: center;
                        gap: 12px;
                    }
                    
                    .stat-badge {
                        background: #f0fdf4;
                        padding: 10px 20px;
                        border-radius: 8px;
                        display: flex;
                        align-items: center;
                        gap: 8px;
                        border: 1px solid #bbf7d0;
                    }
                    
                    .stat-badge .number {
                        font-size: 24px;
                        font-weight: 700;
                        color: #16a34a;
                    }
                    
                    .stat-badge .label {
                        font-size: 13px;
                        color: #15803d;
                        font-weight: 500;
                    }
                    
                    .content { 
                        padding: 0;
                    }
                    
                    .table-wrapper { 
                        overflow-x: auto;
                    }
                    
                    table { 
                        width: 100%;
                        border-collapse: collapse;
                        background: white;
                    }
                    
                    thead {
                        background: #f9fafb;
                        border-top: 1px solid #e5e7eb;
                        border-bottom: 1px solid #e5e7eb;
                    }
                    
                    th { 
                        color: #374151;
                        font-weight: 600;
                        padding: 16px 24px;
                        text-align: left;
                        font-size: 13px;
                        text-transform: uppercase;
                        letter-spacing: 0.5px;
                        border: none;
                    }
                    
                    tbody tr { 
                        transition: background-color 0.15s ease;
                        border-bottom: 1px solid #f3f4f6;
                    }
                    
                    tbody tr:last-child {
                        border-bottom: none;
                    }
                    
                    tbody tr:hover { 
                        background-color: #f9fafb;
                    }
                    
                    td { 
                        padding: 18px 24px;
                        color: #1f2937;
                        font-size: 14px;
                        border: none;
                        vertical-align: middle;
                    }
                    
                    td:first-child { 
                        font-weight: 600;
                        color: #7c3aed;
                        font-family: 'Courier New', monospace;
                        font-size: 13px;
                    }
                    
                    .ncc-code {
                        font-family: 'Courier New', monospace;
                        color: #2563eb;
                        font-weight: 500;
                        font-size: 13px;
                    }
                    
                    .nv-code {
                        font-family: 'Courier New', monospace;
                        color: #dc2626;
                        font-weight: 500;
                        font-size: 13px;
                    }
                    
                    .date-cell {
                        color: #6b7280;
                        font-weight: 500;
                    }
                    
                    .price-cell {
                        font-weight: 600;
                        color: #16a34a;
                        text-align: right;
                        font-family: 'Courier New', monospace;
                    }
                    
                    .empty-state {
                        color: #9ca3af;
                        font-style: italic;
                    }
                    
                    .footer { 
                        background: #f9fafb;
                        padding: 24px 40px;
                        text-align: center;
                        color: #6b7280;
                        font-size: 13px;
                        border-top: 1px solid #e5e7eb;
                    }
                    
                    .footer strong { 
                        color: #16a34a;
                        font-weight: 600;
                    }
                    
                    .company-logo {
                        font-size: 20px;
                        margin-right: 10px;
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
                        
                        .stat-badge {
                            background: white;
                            border: 1px solid #e5e7eb;
                        }
                    }
                    
                    @media (max-width: 768px) { 
                        body {
                            padding: 20px 10px;
                        }
                        
                        .header { 
                            padding: 24px 20px;
                        }
                        
                        .header-content {
                            flex-direction: column;
                            align-items: flex-start;
                        }
                        
                        .header-left h1 { 
                            font-size: 22px;
                        }
                        
                        th, td { 
                            padding: 12px 16px;
                            font-size: 13px;
                        }
                        
                        .stat-badge .number {
                            font-size: 20px;
                        }
                    }
                </style>
            </head>
            <body>
                <div class="container">
                    <div class="header">
                        <div class="header-content">
                            <div class="header-left">
                                <h1><span class="company-logo">📋</span>Danh Sách Phiếu Nhập</h1>
                                <p>Quản lý phiếu nhập hàng từ nhà cung cấp</p>
                            </div>
                            <div class="header-right">
                                <div class="stat-badge">
                                    <span class="number">
                                        <xsl:value-of select="count(//PhieuNhap)"/>
                                    </span>
                                    <span class="label">Phiếu nhập</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <div class="content">
                        <div class="table-wrapper">
                            <table>
                                <thead>
                                    <tr>
                                        <th>Mã Phiếu Nhập</th>
                                        <th>Mã NCC</th>
                                        <th>Mã Nhân Viên</th>
                                        <th>Ngày Nhập</th>
                                        <th style="text-align: right;">Tổng Tiền</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <xsl:for-each select="//PhieuNhap">
                                        <tr>
                                            <td><xsl:value-of select="MaPN"/></td>
                                            <td>
                                                <span class="ncc-code">
                                                    <xsl:value-of select="MaNCC"/>
                                                </span>
                                            </td>
                                            <td>
                                                <span class="nv-code">
                                                    <xsl:value-of select="MaNV"/>
                                                </span>
                                            </td>
                                            <td>
                                                <xsl:choose>
                                                    <xsl:when test="NgayNhap != ''">
                                                        <span class="date-cell">
                                                            <xsl:variable name="dateStr" select="NgayNhap"/>
                                                            <xsl:choose>
                                                                <xsl:when test="contains($dateStr, 'T')">
                                                                    <xsl:value-of select="concat(substring($dateStr, 9, 2), '/', substring($dateStr, 6, 2), '/', substring($dateStr, 1, 4), ' ', substring($dateStr, 12, 5))"/>
                                                                </xsl:when>
                                                                <xsl:when test="string-length($dateStr) >= 10">
                                                                    <xsl:value-of select="concat(substring($dateStr, 9, 2), '/', substring($dateStr, 6, 2), '/', substring($dateStr, 1, 4))"/>
                                                                    <xsl:if test="string-length($dateStr) > 10">
                                                                        <xsl:text> </xsl:text>
                                                                        <xsl:value-of select="substring($dateStr, 12, 5)"/>
                                                                    </xsl:if>
                                                                </xsl:when>
                                                                <xsl:otherwise>
                                                                    <xsl:value-of select="NgayNhap"/>
                                                                </xsl:otherwise>
                                                            </xsl:choose>
                                                        </span>
                                                    </xsl:when>
                                                    <xsl:otherwise>
                                                        <span class="empty-state">Chưa cập nhật</span>
                                                    </xsl:otherwise>
                                                </xsl:choose>
                                            </td>
                                            <td class="price-cell">
                                                <xsl:choose>
                                                    <xsl:when test="TongTien != '' and TongTien != '0' and TongTien != '0.00'">
                                                        <xsl:value-of select="format-number(TongTien, '#,##0')"/>
                                                        <xsl:text> đ</xsl:text>
                                                    </xsl:when>
                                                    <xsl:otherwise>
                                                        <span class="empty-state">0 đ</span>
                                                    </xsl:otherwise>
                                                </xsl:choose>
                                            </td>
                                        </tr>
                                    </xsl:for-each>
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