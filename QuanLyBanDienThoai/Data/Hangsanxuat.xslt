<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output method="html" encoding="UTF-8" indent="yes"/>
    
    <xsl:template match="/">
        <html lang="vi">
            <head>
                <meta charset="utf-8"/>
                <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
                <title>Danh Sách Hãng Sản Xuất</title>
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
                        background: #fef3c7;
                        padding: 10px 20px;
                        border-radius: 8px;
                        display: flex;
                        align-items: center;
                        gap: 8px;
                        border: 1px solid #fde68a;
                    }
                    
                    .stat-badge .number {
                        font-size: 24px;
                        font-weight: 700;
                        color: #d97706;
                    }
                    
                    .stat-badge .label {
                        font-size: 13px;
                        color: #92400e;
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
                        color: #d97706;
                        font-family: 'Courier New', monospace;
                        font-size: 13px;
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
                        color: #d97706;
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
                                <h1><span class="company-logo">🏭</span>Danh Sách Hãng Sản Xuất</h1>
                                <p>Quản lý thông tin các hãng sản xuất điện thoại</p>
                            </div>
                            <div class="header-right">
                                <div class="stat-badge">
                                    <span class="number">
                                        <xsl:value-of select="count(//HangSanXuat)"/>
                                    </span>
                                    <span class="label">Hãng sản xuất</span>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <div class="content">
                        <div class="table-wrapper">
                            <table>
                                <thead>
                                    <tr>
                                        <th>Mã Hãng</th>
                                        <th>Tên Hãng</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <xsl:for-each select="//HangSanXuat">
                                        <tr>
                                            <td><xsl:value-of select="MaHang"/></td>
                                            <td><xsl:value-of select="TenHang"/></td>
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